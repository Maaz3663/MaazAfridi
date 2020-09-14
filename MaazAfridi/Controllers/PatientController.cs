using MaazAfridi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaazAfridi.Controllers
{
    public class PatientController : Controller
    {
        
        private PatientDb db = new PatientDb();

        public ActionResult Index(string search)
        {
            if (search != null)
            {
                return View(db.Patient.Where(x => x.Name.Contains(search)).ToList());
            }
            
                return View(db.Patient.ToList());
            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patient p)
        {
            if (ModelState.IsValid)
            {
                db.Patient.Add(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

    }
}