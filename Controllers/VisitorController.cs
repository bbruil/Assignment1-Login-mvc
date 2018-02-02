using Assignment1_Login_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1_Login_mvc.Controllers
{
    public class VisitorController : Controller 
    {
        private MyDbContext db = new MyDbContext();

        [HttpPost]
        public ActionResult Create(Visitor visitor )
        {

            db.Visitors.Add(visitor);
            db.SaveChanges();
            return View("Index", db.Visitors);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(db.Visitors);
        }


        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Visitors);
        }
    }
}