namespace ABONAP_MVC.Models
{
    public class Branch : BaseEntity
    {
        public string Description { get; init; }
        public int IdCompany { get; init; }
        public Branch(int? IdBranch, string Description, int IdCompany, string Code, bool Status) 
            :base(IdBranch,Code, Status, DateTime.Now, DateTime.Now)
        {
            this.Description = Description; 
            this.IdCompany = IdCompany;
        }
    }
}
