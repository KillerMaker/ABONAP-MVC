
using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public class CompanyHandler : BaseHandler<Company>
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

        public override IEnumerable<SqlParameter> GetSqlParameters(Company entity)
        {
            throw new NotImplementedException();
        }

        public override string GetUpdateQuery(int Id)
        {
            throw new NotImplementedException();
        }

        public override Company MapObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
