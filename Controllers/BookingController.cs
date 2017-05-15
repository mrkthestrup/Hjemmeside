using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hjemmeside2.Models.Entities;
using hjemmeside2.Models.Repositories;

namespace hjemmeside2.Controllers
{

    public class BookingController : Controller
    {
        // Tight Couple
       // MyDbContext db = new MyDbContext();

       //Loosly Couple
        private IBookingRepository bookingRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        // Index
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Booking> bookings = bookingRepository.GetAll();
            return View(bookings);
        }
        //Create
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
                bookingRepository.Create(st);
                return RedirectToAction("Index");
            }
            else 
            {
                return View();
            }
           
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
           Booking booking =  bookingRepository.Get(id);
           
            return View(booking);
        }

        //Delete
        [HttpPost]
        public IActionResult Delete(Booking bk)
        {
            bookingRepository.Delete(bk);
            
            return RedirectToAction("Index");
        }

        //Eidt or update
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Booking booking =  bookingRepository.Get(id);
           
            return View(booking);
        }
      
      //Eidt or update
       [HttpPost]
        public IActionResult Edit(Booking bk)
        {
           // if (ModelState.IsValid)
            // {
                bookingRepository.Update(bk);
             //   return RedirectToAction("Index");
           // }
            return View(bk);
        }
        
        //Details
        [HttpGet]
        public IActionResult Details(int id)
        {
           Booking booking =  bookingRepository.Get(id);
           
            return View(booking);
        }
    }
}