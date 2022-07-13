namespace ABONAP_MVC.Models
{
    public class Customer:BaseEntity
    {
        public int IdPerson { get; init; }
        public string IdBranch { get; init; }

        public Customer(int? IdCustomer, int IdPerson, string IdBranch, string Code, bool Status)
            : base(IdCustomer,Code, Status, DateTime.Now, DateTime.Now)
        {
            this.IdPerson = IdPerson;
            this.IdBranch = IdBranch;
        }
    }
}
