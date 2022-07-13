namespace ABONAP_MVC.Models
{
    public class Company : BaseEntity
    {
        public string Description { get; init; }

        public Company(int? IdCompany, string Description, string Code, bool Status)
            :base(IdCompany,Code,Status,DateTime.Now,DateTime.Now)
        {
            this.Description = Description;
        }
    }
}
