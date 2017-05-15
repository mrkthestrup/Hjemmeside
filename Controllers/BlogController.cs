using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hjemmeside2.Models;
using hjemmeside2.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace hjemmeside2.Controllers
{   
    [Route("blog")]
    public class BlogController : Controller
    { 
        private readonly MyDbContext _db;

     
       public BlogController(MyDbContext db)
       {
           _db = db;
       }

        [Route("")]
        public IActionResult Index(int page = 0)
        {
            var posts = _db.Blogs.OrderByDescending(x => x.Posted).Take(5).ToArray();

            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = _db.Blogs.FirstOrDefault(x => x.Key == key);
            return View(post);
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Models.Entities.BlogPost post)
        {
            if (!ModelState.IsValid)
                return View();

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Blogs.Add(post);
            _db.SaveChanges();

            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }
    }
}