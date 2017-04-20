using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hjemmeside2.Models;

namespace hjemmeside2.Controllers
{

    public class BookingController : Controller
    {
       MyDbContext db = new MyDbContext();
        // Index
        [HttpGet]
        public IActionResult Index()
        {
            List<Booking> Bookings = db.Bookings.ToList();
            return View(Bookings);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Booking st)
        {

            if(ModelState.IsValid)
            {
                db.Bookings.Add(st);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            {
                return View();
            }

           
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Booking Bookings = db.Bookings.Find(id);

            return View(Bookings);
        }
    }
}