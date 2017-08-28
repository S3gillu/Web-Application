using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using System.Data;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {

        private DataContext db = new DataContext();
        static string Cname = "";
        // GET: /Home/
       public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
       

        // GET: /Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: /Home/Create
        public ActionResult Create()
        {
            ViewBag.Countries = db.Countries.ToList();
            return View();
        }
        private IList<State> GetState(int Countryid)
        {
            var data = db.States.Where(m => m.country_id == Countryid).ToList();

            return data;

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empid,empname,empfathername,empsalary,country_name,state_name,email")]
        Worker employee, FormCollection frm)
        {
            if (ModelState.IsValid)
            {
                Worker em = new Worker();
               em.country_name = Cname;
                int sname = Convert.ToInt16(frm["state_name"]);
                em.state_name = db.States.Single(x => x.state_id == sname).state_name;
                 em.state_name = frm["state_name"];
                em.empname = frm["empname"];
               
                em.email = frm["email"];
              //  em.BirthDate = frm["BirthDate"];
                em.Address = frm["Address"];
                db.Employees.Add(em);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}