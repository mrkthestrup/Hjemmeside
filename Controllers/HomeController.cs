using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hjemmeside2.Models;
using hjemmeside2.Models.Repositories;
using hjemmeside2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace hjemmeside2.Controllers
{
    public class HomeController : Controller
    {
          private MyDbContext _db;

          private IArticelRepository ariticelRepository; 

     
       public HomeController(MyDbContext db, IArticelRepository ariticelRepository )
       {
           this.ariticelRepository = ariticelRepository;
           _db = db;
       }

          public IActionResult Index()
        {
            ViewArticelBlogPost vab = new ViewArticelBlogPost();
            vab.articels = ariticelRepository.GetAll();
            vab.blogs = _db.Blogs.OrderByDescending(x => x.Posted).Take(5).ToArray();

           return View(vab);
           
        }

        public IActionResult About()
        {
            ViewArticelBlogPost vab = new ViewArticelBlogPost();
            vab.articels = ariticelRepository.GetAll();

            return View(vab);
        }

        public IActionResult Contact()
        {
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
