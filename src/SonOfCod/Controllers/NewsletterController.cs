using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SonOfCod.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;

        public NewsletterController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        //GET: /Newsletter/Index/
        public IActionResult Index()
        {
            return View();
        }
        //GET: /Newsletter/Subscribe/
        public IActionResult Subscribe()
        {
            return View();
        }
        //POST: /Newsletter/Subscribe/
        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("SubSuccess", new { id = subscriber.SubscriberId });
        }
        //GET: /Newsletter/Unsubscribe/
        public IActionResult Unsubscribe()
        {
            return View();
        }
        //POST: /Newsletter/Unsubscribe/
        [HttpPost]
        public IActionResult Unsubscribe(Subscriber subscriber)
        {
            Subscriber currentSub = _db.Subscribers.FirstOrDefault(s => s.Email == subscriber.Email);
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

        //GET: /Newsletter/SubSuccess/
        public IActionResult SubSuccess(int id)
        {
            ViewBag.Subscriber = _db.Subscribers.FirstOrDefault(s => s.SubscriberId == id);
            return View();
        }

        //GET: /Newsletter/UnsubSuccess/
        public IActionResult UnsubSuccess()
        {
            return View();
        }
    }
}
