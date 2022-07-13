namespace ABONAP_MVC.Models
{
    public class Department : BaseEntity
    {
        public string Description { get; init; }
        public int IdSucursal { get; init; }

        public Department(int? IdDepartment, string Description, string Code, bool Status, int IdSucursal)
            :base(IdDepartment,Code,Status,DateTime.Now,DateTime.Now)
        {
            this.Description = Description;
            this.IdSucursal = IdSucursal;
        }

    }
}
