using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebLearningMVCEF.Data;
using WebLearningMVCEF.Models;

namespace WebLearningMVCEF.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminPanelController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<User> usersList = _db.Users;

            return View(usersList);
        }

        public IActionResult NewUser()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUser(User newUser)
        {
            // This is server side validation, but it's to easy task to do it on server side, better is Client Side Validation implemented directly in View
            if (ModelState.IsValid)
            {
                _db.Users.Add(newUser);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newUser);
        }
    }
}
