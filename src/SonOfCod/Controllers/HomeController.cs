﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;
        
        public HomeController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        //GET: /Home/Subscribe/
        public IActionResult Subscribe()
        {
            return View();
        }
        //POST: /Home/Subscribe/
        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("SubSuccess" , new { id = subscriber.SubscriberId });
        }
        //GET: /Home/Unsubscribe/
        public IActionResult Unsubscribe()
        {
            return View();
        }
        //POST: /Home/Unsubscribe/
        [HttpPost]
        public IActionResult Unsubscribe(Subscriber subscriber)
        {
            Subscriber currentSub = _db.Subscribers.FirstOrDefault(s=> s.Email == subscriber.Email);
            if (currentSub != null)
            {
                _db.Remove(currentSub);
                _db.SaveChanges();
                return RedirectToAction("UnsubSuccess");
            }
            else
            {
                return View();
            }
        }

        //GET: /Home/SubSuccess/
        public IActionResult SubSuccess(int id)
        {
            ViewBag.Subscriber = _db.Subscribers.FirstOrDefault(s => s.SubscriberId == id);
            return View();
        }

        //GET: /Home/UnsubSuccess/
        public IActionResult UnsubSuccess()
        {
            return View();
        }
    }
}
