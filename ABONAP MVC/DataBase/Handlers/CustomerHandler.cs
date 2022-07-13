using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public class CustomerHandler : BaseHandler<Customer>
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

        public override IEnumerable<SqlParameter> GetSqlParameters(Customer entity)
        {
            throw new NotImplementedException();
        }

        public override string GetUpdateQuery(int Id)
        {
            throw new NotImplementedException();
        }

        public override Customer MapObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
