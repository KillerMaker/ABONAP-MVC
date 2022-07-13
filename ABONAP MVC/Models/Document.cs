namespace ABONAP_MVC.Models
{
    public class Document:BaseEntity
    {
        public string Description { get; init; }
        public int IdDocumentType { get; init; }

        public Document(int? IdDocument,string Description, int IdDocumentType, string Code, bool Status)
            :base(IdDocument,Code, Status, DateTime.Now, DateTime.Now)
        {
            this.Description = Description;
            this.IdDocumentType = IdDocumentType;
        }
    }
}
