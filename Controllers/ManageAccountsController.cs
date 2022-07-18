using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Collections.Generic;
using WebLearningMVCEF.Data;
using WebLearningMVCEF.Models;
using WebLearningMVCEF.Models.ViewModels;
using System.Threading.Tasks;

namespace WebLearningMVCEF.Controllers
{
    public class ManageAccountsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ManageAccountsController(ApplicationDbContext db)
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
            //IEnumerable<SelectListItem> TypeDropDown = _db.RolesTypes.Select(i => new SelectListItem
            //{
            //    Text = i.Name,
            //    Value = i.Id.ToString()
            //});

            //ViewBag.TypeDropDown = TypeDropDown;

            UserVM userVM = new()
            {
                User = new User(),
                RolesTypesDropDown = _db.RolesTypes.Select(item => new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                })
            };

            return View(userVM);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUser(UserVM userVM)
        {
            // This is server side validation, but it's to easy task to do it on server side, better is Client Side Validation implemented directly in View
            if (ModelState.IsValid)
            {
                _db.Users.Add(userVM.User);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userVM);
        }

        public IActionResult DeleteUser(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            User obj = _db.Users.Find(id);

            if (obj == null) {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUserPost(int? id)
        {
            User obj = _db.Users.Find(id);
            if (obj == null) 
            { 
                return NotFound(); 
            }

            _db.Users.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateUser(int? id)
        {
            //User obj = _db.Users.Find(id);

            //if (obj == null)
            //{
            //    return NotFound();
            //}

            //IEnumerable<SelectListItem> TypeDropDown = _db.RolesTypes.Select(i => new SelectListItem
            //{
            //    Text = i.Name,
            //    Value = i.Id.ToString()
            //});

            //ViewBag.TypeDropDown = TypeDropDown;

            UserVM userVM = new UserVM()
            {
                User = new User(),
                RolesTypesDropDown = _db.RolesTypes.Select(item => new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                })
            };

            if (id == null || id == 0)
            {
                return NotFound();
            }

            userVM.User = _db.Users.Find(id);

            if (userVM.User == null)
            {
                return NotFound();
            }

            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateUser(UserVM userVM)
        {

            //userVM.User.RoleType = _db.RolesTypes.Find(2);

            if (ModelState.IsValid)
            {
                _db.Users.Update(userVM.User);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userVM);
        }
    }
}
