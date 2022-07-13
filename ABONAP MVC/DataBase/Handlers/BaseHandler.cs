using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public abstract class BaseHandler<T> : IDbSelectable<T>, IDbDMLEntity<T> where T : BaseEntity
    {
        public abstract string GetInsertionQuery();

        public abstract string GetSelectQuery();

        public abstract IEnumerable<SqlParameter> GetSqlParameters(T entity);

        public abstract string GetUpdateQuery(int Id);

        public abstract T MapObject(SqlDataReader reader);

        public abstract string GetDeleteQuery(int id);
    }
}
