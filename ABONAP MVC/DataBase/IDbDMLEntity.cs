using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public interface IDbDMLEntity<in T> where T : BaseEntity
    {
        public abstract IEnumerable<SqlParameter> GetSqlParameters(T entity);
        public string GetInsertionQuery();
        public string GetUpdateQuery(int id);
        public string GetDeleteQuery(int id);
    }
}
