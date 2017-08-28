using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        ContextClass context;
        // GET: Home

        public HomeController()
        {

            context = new ContextClass();
        }

        public ActionResult Index()
        {
            return View(context.NewCustomers.ToList());

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "Id,Name,email")]NewCustomer newCustomer)
        {
            if (ModelState.IsValid)
            {
                context.NewCustomers.Add(newCustomer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newCustomer);

        }
        [HttpGet]
        public ActionResult cool()
        {
            List<SelectListItem> statelist = new List<SelectListItem>();
            statelist.Add(new SelectListItem
            {
                Text = "Utter Pradesh",
                Value = "utter Pradesh"
            });
            statelist.Add(new SelectListItem
            {
                Text = "Delhi",
                Value = "Delhi"
            });
            statelist.Add(new SelectListItem
            {
                Text = "Maharastra",
                Value = "Maharastra"
            });
            statelist.Add(new SelectListItem
            {
                Text = "Goa",
                Value = "Goa"
            });
            ViewBag.StateList = statelist;
            return View();

        }
    }
}
