using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hjemmeside2.Models;
using hjemmeside2.Models.Entities;
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
        public IActionResult Index()
        {// tager efter dato
           IEnumerable<BlogPost> posts = _db.Blogs.OrderByDescending(x => x.Posted); 
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

          //  post.Author = User.Identity.Name;
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

        [HttpGet, Route("Delete")]
        public IActionResult Delete(long Id)
        {
           BlogPost blog2 = _db.Blogs.Find(Id);
            return View(blog2);
        }

        //Delete
        [HttpPost, Route("Delete")]
        public IActionResult Delete(BlogPost bp)
        {
             BlogPost blogs = _db.Blogs.Find(bp.Id);
            _db.Blogs.Remove(blogs);
            _db.SaveChanges();
           
            return RedirectToAction("");
        }

        //Eidt or update
        [HttpGet, Route("Edit")]
        public IActionResult Edit(long Id)
        {
           BlogPost blog2 = _db.Blogs.Find(Id);
            return View(blog2);
        }
      
      //Edit or update
       [HttpPost, Route("Edit")]
        public IActionResult Edit(BlogPost bp)
        {
           
            bp.Posted = DateTime.Now;

                _db.Blogs.Update(bp);
                _db.SaveChanges();
                    
            return RedirectToAction("Post", "Blog", new
            {
                year = bp.Posted.Year,
                month = bp.Posted.Month,
                key = bp.Key
            });
        }        
    }
}