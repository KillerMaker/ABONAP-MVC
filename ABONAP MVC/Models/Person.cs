
using ABONAP_MVC.DataBase;
using ABONAP_MVC.DataBase.Handlers;

namespace ABONAP_MVC.Models
{
    public class Person : BaseEntity
    {
        public string Names { get; init; }
        public string LastName1 { get; init; }
        public string LastName2 { get; init; }


        public Person(int? IdPerson, string Names, string LastName1, string LastName2, string Code, bool Status)
            :base(IdPerson,Code, Status, DateTime.Now, DateTime.Now)
        {
            this.Names = Names; 
            this.LastName1 = LastName1;
            this.LastName2 = LastName2;
        }
    }
}
