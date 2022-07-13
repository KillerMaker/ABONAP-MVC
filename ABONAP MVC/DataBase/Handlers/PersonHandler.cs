using ABONAP_MVC.Models;
using System.Data.SqlClient;
#nullable disable

namespace ABONAP_MVC.DataBase.Handlers
{
    public class PersonHandler : BaseHandler<Person>
    {
        public override IEnumerable<SqlParameter> GetSqlParameters(Person person)
        {
              var parameters = new List<SqlParameter>()
             {
                new SqlParameter("@NAMES",person.Names),
                new SqlParameter("@LAST_NAME1", person.LastName1),
                new SqlParameter("@LAST_NAME2", person.LastName2),
                new SqlParameter("@CODE", person.Code),
                new SqlParameter("@STATUS",person.Status),
                new SqlParameter("@CREATION_DATE", person.CreateDate),
                new SqlParameter("@UPDATE_DATE", person.UpdateDate)
             };

            if (person.Id.HasValue)
                parameters.Add(new SqlParameter("@ID_PERSON", person.Id.Value));

            return parameters;
        }
         
        public override Person MapObject(SqlDataReader reader)
        {
            int id;
            bool status;
            DateTime createDate;
            DateTime updateDate;

            return new Person
            (
               int.TryParse(reader["ID_PERSONA"].ToString(), out id)? id : null,
               reader["NOMBRES"].ToString(),
               reader["PRIMER_APELLIDO"].ToString(),
               reader["SEGUNDO_APELLIDO"].ToString(),
               reader["CODIGO"].ToString(),
               bool.TryParse(reader["ESTADO"].ToString(),out status)? status : default
            )
            {
                CreateDate = DateTime.TryParse(reader["FECHA_CREACION"].ToString(), out createDate)? createDate : default,
                UpdateDate = DateTime.TryParse(reader["FECHA_ACTUALIZACION"].ToString(), out updateDate)? updateDate : default
            };
        }
           

        public override string GetInsertionQuery() =>
            @"INSERT INTO PERSONA(NOMBRES, PRIMER_APELLIDO, SEGUNDO_APELLIDO, CODIGO, ESTADO)
              VALUES(@NAMES, @LAST_NAME1, @LAST_NAME2, @CODE, @STATUS);";

        public override string GetUpdateQuery(int Id) =>
            @$"UPDATE PERSONA SET 
                NOMBRES = @NAMES, PRIMER_APELLIDO = @LAST_NAME1, SEGUNDO_APELLIDO = @LAST_NAME2,
                CODIGO = @CODE, ESTADO = @STATUS, FECHA_ACTUALIZACION = @UPDATE_DATE
             WHERE ID_PERSONA = {Id}";

        public override string GetSelectQuery() =>
            "SELECT * FROM PERSONA;";

        public override string GetDeleteQuery(int id) =>
            $"DELETE FROM PERSONA WHERE ID_PERSONA = {id}";
    }
}
