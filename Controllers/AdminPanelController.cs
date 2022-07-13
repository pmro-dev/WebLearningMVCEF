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
    }
}
