using First_Project.Data;
using First_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace First_Project.Controllers
{
    public class FormController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FormController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public IActionResult Index()
        {
            List<Form> form = _db.FormTable.ToList();
            return View(form);
        }


        //GET - For Create Form
        public IActionResult Create()
        {
            //List<Form> province = _db.province();
         //   pl = (from c in _db.province select c).ToList();
            return View();
        }

        //POST - For Post Form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Form obj)
        {
            if (ModelState.IsValid)
            {
                _db.FormTable.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
