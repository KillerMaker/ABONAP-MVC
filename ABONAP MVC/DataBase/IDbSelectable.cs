using ABONAP_MVC.Models;
using System.Data.SqlClient;
using System.Data;

namespace ABONAP_MVC.DataBase
{
    public interface IDbSelectable<out T>
    {
        public T MapObject(SqlDataReader reader);
        public string GetSelectQuery();
    }
}
