#nullable disable
using ABONAP_MVC.Models;
using System.Data.SqlClient;

namespace ABONAP_MVC.DataBase.Handlers
{
    public class CompanyHandler : BaseHandler<Company>
    {
        public override string GetDeleteQuery(int id) => 
            $"DELETE FROM EMPRESA WHERE ID_EMPRESA = {id}";

        public override string GetInsertionQuery() =>
            @"INSERT INTO EMPRESA(DESCRIPCION,CODIGO,ESTADO)VALUES(@DESCRIPTION,@CODE,@STATUS);";

        public override string GetSelectQuery() =>
            @"SELECT * FROM COMPANY";

        public override IEnumerable<SqlParameter> GetSqlParameters(Company company)
        {
            var parameters = new List<SqlParameter>()
            { 
                new SqlParameter("@DESCRIPTION", company.Description),
                new SqlParameter("@CODE", company.Code),
                new SqlParameter("@STATUS",company.Status),
                new SqlParameter("@CREATION_DATE", company.CreateDate),
                new SqlParameter("@UPDATE_DATE", company.UpdateDate)
             };

            if (company.Id.HasValue)
                parameters.Add(new SqlParameter("@ID_PERSON", company.Id.Value));

            return parameters;
        }

        public override string GetUpdateQuery(int id) =>
            $@"UPDATE EMPRESA SET 
                DESCRIPCION = @DESCRIPTION, 
                CODIGO = @CODE, 
                ESTADO = @STATUS,
                FECHA_ACTUALIZACION = @UPDATE_DATE
            WHERE ID_EMPRESA = {id}";

        public override Company MapObject(SqlDataReader reader)
        {
            int id;
            bool status;
            DateTime createDate;
            DateTime updateDate;

            return new Company
            (
                int.TryParse(reader["ID_EMPRESA"].ToString(), out id) ? id : null,
                reader["DESCRIPCION"].ToString(),
                reader["CODIGO"].ToString(),
                bool.TryParse(reader["ID_EMPRESA"].ToString(), out status) ? status : default
            )
            {
                CreateDate = DateTime.TryParse(reader["FECHA_CREACION"].ToString(), out createDate)? createDate : default,
                UpdateDate = DateTime.TryParse(reader["FECHA_ACTUALIZACION"].ToString(), out updateDate) ? updateDate : default

            };
        }
    }
}
