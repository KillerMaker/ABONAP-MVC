namespace ABONAP_MVC.Models
{
    public class Loan:BaseEntity
    {
        public int IdCustomer { get; init; }
        public decimal Amount { get; init; }

        public Loan(int? IdLoan, int IdCustomer, decimal Amount, string Code, bool Status)
            :base(IdLoan,Code, Status, DateTime.Now, DateTime.Now)
        {
            this.IdCustomer = IdCustomer;
            this.Amount = Amount;
        }
    }
}
