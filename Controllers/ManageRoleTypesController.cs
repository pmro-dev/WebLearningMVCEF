using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebLearningMVCEF.Data;
using WebLearningMVCEF.Models;

namespace WebLearningMVCEF.Controllers
{
    public class ManageRoleTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManageRoleTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoleTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RolesTypes.ToListAsync());
        }

        // GET: RoleTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleType = await _context.RolesTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleType == null)
            {
                return NotFound();
            }

            return View(roleType);
        }

        // GET: RoleTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoleTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,AccessLevel")] RoleType roleType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roleType);
        }

        // GET: RoleTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleType = await _context.RolesTypes.FindAsync(id);
            if (roleType == null)
            {
                return NotFound();
            }
            return View(roleType);
        }

        // POST: RoleTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,AccessLevel")] RoleType roleType)
        {
            if (id != roleType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleTypeExists(roleType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roleType);
        }

        // GET: RoleTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleType = await _context.RolesTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleType == null)
            {
                return NotFound();
            }

            return View(roleType);
        }

        // POST: RoleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleType = await _context.RolesTypes.FindAsync(id);
            _context.RolesTypes.Remove(roleType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleTypeExists(int id)
        {
            return _context.RolesTypes.Any(e => e.Id == id);
        }
    }
}
