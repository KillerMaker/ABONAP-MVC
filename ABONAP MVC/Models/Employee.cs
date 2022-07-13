namespace ABONAP_MVC.Models
{
    public class Employee:BaseEntity
    {
        public int IdPerson { get; init; }
        public int IdBranch { get; init; }

        public Employee(int? IdEmployee, int IdPerson, int IdBranch, string Code, bool Status)
            :base(IdEmployee,Code, Status, DateTime.Now, DateTime.Now)
        {
            this.IdPerson = IdPerson;
            this.IdBranch = IdBranch;
        }

    }
}
