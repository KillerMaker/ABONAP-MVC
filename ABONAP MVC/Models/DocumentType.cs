namespace ABONAP_MVC.Models
{
    public class DocumentType
    {
        public int? IdDocumentType { get; init; }
        public string Description { get; init; }
        public string Code { get; init; }

        public DocumentType(int IdDocumentType, string Description, string Code)
        {
            this.IdDocumentType = IdDocumentType;
            this.Description = Description;
            this.Code = Code;
        }
    }
}
