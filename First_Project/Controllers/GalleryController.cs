using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace First_Project.Controllers
{
    public class GalleryController : Controller
    {
        private readonly string wwwrootDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        public IActionResult Index()
        {
            List<string> images = Directory.GetFiles(wwwrootDirectory, "*jpg").Select(Path.GetFileName).ToList();
            return View(images);
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile myFile)
        {
            if(myFile != null)
            {
                var path = Path.Combine(wwwrootDirectory, DateTime.Now.Ticks.ToString() + Path.GetExtension(myFile.FileName));


            using (var stream = new FileStream(path, FileMode.Create))
                {
                    await myFile.CopyToAsync(stream);
                }
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
