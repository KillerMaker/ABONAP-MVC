using ABONAP_MVC.DataBase.Handlers;
using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.Data_Base
{
    public class DBAdapter
    {
        private string connectionString;
        public DBAdapter(string connectionString) =>
            this.connectionString = connectionString;

        public async IAsyncEnumerable<T> RunSelectQuery<T>(BaseHandler<T> handler) where T : BaseEntity
        {
            using(var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(handler.GetSelectQuery(), connection))
                    using (var reader = await command.ExecuteReaderAsync())
                        while (await reader.ReadAsync())
                            yield return handler.MapObject(reader);
            }
        }

        public async Task RunCommand<T>(T obj, DbOperation operation, BaseHandler<T> handler) where T : BaseEntity
        {
            string query = "";
            switch(operation)
            {
                case DbOperation.Insert:
                    query = handler.GetInsertionQuery();
                    break;
                case DbOperation.Update:
                    query = handler.GetUpdateQuery(obj.Id.HasValue?
                        obj.Id.Value : throw new Exception("Can't update without ID"));
                    break;
                case DbOperation.Delete:
                    query = handler.GetDeleteQuery(obj.Id.HasValue ?
                        obj.Id.Value : throw new Exception("Can't delete without ID"));
                    break;
            }
            using(var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    foreach(var parameter in handler.GetSqlParameters(obj))
                        command.Parameters.Add(parameter);

                    await command.ExecuteNonQueryAsync();
                }
            }
            
        }
    }
}
