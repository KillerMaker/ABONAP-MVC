using ABONAP_MVC.DataBase;
using ABONAP_MVC.DataBase.Handlers;
using Microsoft.Extensions.Configuration;

namespace ABONAP_MVC.Models
{
    public abstract class BaseEntity
    {
        public int? Id { get; init; }
        public DateTime? CreateDate { get; init; }
        public DateTime? UpdateDate { get; init; }
        public string Code { get; init; }
        public bool Status { get; init; }
        

        public BaseEntity(int? Id,string Code, bool Status, DateTime? CreateDate, DateTime? UpdateDate)
        {
            this.Id = Id;
            this.Code = Code;
            this.Status = Status;
            this.CreateDate = CreateDate;
            this.UpdateDate = UpdateDate;
        }
    }
}
