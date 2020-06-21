using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Db_Api_CRUD.Models;

namespace Db_Api_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private crud_api_dbEntities _db = new crud_api_dbEntities();
        public ActionResult Index()
        {
            return View(_db.ski_jumpers.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Simple app allowing for CRUD operations on a Table";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me @ jaca09001@gmail.com";

            return View();
        }

        public ActionResult Create(ski_jumpers jumper)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                _db.ski_jumpers.Add(jumper);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}