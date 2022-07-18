using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public class DocumentHandler : BaseHandler<Document>
    {
        public override string GetDeleteQuery(int id) => "DELETE FROM DOCUMENT";

        public override string GetInsertionQuery() =>
            @"INSERT INTO DOCUMENTO(DESCRIPCION,ESTADO,ID_TIPO_DOCUMENTO)
                VALUES(@DESCRIPTION,@STATUS,@DOCUMENT_TYPE);";

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
