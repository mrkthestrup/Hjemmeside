using System;
using System.Collections.Generic;
using hjemmeside2.Models.Entities;
using hjemmeside2.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace hjemmeside2.Controllers
{
    public class ArticelController : Controller
    {
        private IArticelRepository articelRepository;

        public ArticelController(IArticelRepository articelRepository)
        {
            this.articelRepository = articelRepository;
        }

        // Index
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Articel> al = articelRepository.GetAll();
            return View(al);
        }
        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Articel al)
        {
            if(ModelState.IsValid)
            {
                al.Posted = DateTime.Now;
                articelRepository.Create(al);
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
           Articel al =  articelRepository.Get(id);
           
            return View(al);
        }

        //Delete
        [HttpPost]
        public IActionResult Delete(Articel al)
        {
            articelRepository.Delete(al);
            
            return RedirectToAction("Index");
        }

        //Eidt or update
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Articel al =  articelRepository.Get(id);
           
            return View(al);
        }
      
      //Eidt or update
       [HttpPost]
        public IActionResult Edit(Articel al)
        {
           if (ModelState.IsValid)
             {
                 al.Posted = DateTime.Now;
                articelRepository.Update(al);
              return RedirectToAction("Index");
           }
            return View(al);
        }
        
        //Details
        [HttpGet]
        public IActionResult Details(int id)
        {
           Articel al =  articelRepository.Get(id);
           
            return View(al);
        }
        
    }
}