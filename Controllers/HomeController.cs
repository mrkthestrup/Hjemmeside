using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hjemmeside2.Models;
using Microsoft.AspNetCore.Mvc;

namespace hjemmeside2.Controllers
{
    public class HomeController : Controller
    {
          private readonly MyDbContext _db;

     
       public HomeController(MyDbContext db)
       {
           _db = db;
       }

          public IActionResult Index(int page = 0)
        {
            var posts = _db.Blogs.OrderByDescending(x => x.Posted).Take(5).ToArray();

            return View(posts);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult HIT()
        {
        
            return View();
        }

        public IActionResult Pris()
        {
            return View();
        }
       
    }
}
