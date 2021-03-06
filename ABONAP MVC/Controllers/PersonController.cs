using ABONAP_MVC.Data_Base;
using ABONAP_MVC.DataBase.Handlers;
using ABONAP_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABONAP_MVC.Controllers
{
    public class PersonController : Controller
    {
        private DBAdapter dbAdapter;
        public PersonController(DBAdapter dbAdapter)
        {
            this.dbAdapter = dbAdapter;
        }
        public IActionResult Show()
        {
            IAsyncEnumerable<Person> persons = dbAdapter.RunSelectQuery(new PersonHandler());
            return View("Show",persons);
        }
        public IActionResult Create() => View("Create");

        [HttpPost]
        public async Task<IActionResult> CreateInDB()
        {
            string names = Request.Form["Names"].ToString();
            string lastName1 = Request.Form["LastName1"].ToString();
            string lastName2 = Request.Form["LastName2"].ToString();
            string code = Request.Form["Code"].ToString();

            Person person = new Person(null,names,lastName1,lastName2,code,true);

            await dbAdapter.RunCommand(person, DbOperation.Insert, new PersonHandler());

            return RedirectToAction("Show");
        }

        public IActionResult Update(int id, string names, string lastName1, string lastName2, string code, bool status) 
        {
           TempData["Id"] = id;
           Person person = new Person(id, names, lastName1, lastName2, code, status);
           return View("Update",person); 
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInDB(int id)
        {
            string names = Request.Form["Names"].ToString();
            string lastName1 = Request.Form["LastName1"].ToString();
            string lastName2 = Request.Form["LastName2"].ToString();
            string code = Request.Form["Code"].ToString();

            Person person = new Person(id, names, lastName1, lastName2, code, true);

            await dbAdapter.RunCommand(person, DbOperation.Update, new PersonHandler());

            return RedirectToAction("Show");
        }

        public async Task<IActionResult> Delete(int id, string names, string lastName1, string lastName2, string code, bool status)
        {
            Person person = new Person(id, names, lastName1, lastName2, code, status);
            await dbAdapter.RunCommand(person, DbOperation.Delete, new PersonHandler());
            return RedirectToAction("Show");
        }

    }
}
