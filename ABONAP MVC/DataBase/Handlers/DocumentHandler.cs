using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public class DocumentHandler : BaseHandler<Document>
    {
        public override string GetDeleteQuery(int id)
        {
            throw new NotImplementedException();
        }

        public override string GetInsertionQuery()
        {
            throw new NotImplementedException();
        }

        public override string GetSelectQuery()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<SqlParameter> GetSqlParameters(Document entity)
        {
            throw new NotImplementedException();
        }

        public override string GetUpdateQuery(int Id)
        {
            throw new NotImplementedException();
        }

        public override Document MapObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
