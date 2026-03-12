using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;
using University_Management_System.Models;

namespace University_Management_System.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly UniversityManagementDBcontext _context;

        public DepartmentController(UniversityManagementDBcontext context)
        {
            _context = context;
        }

        // GET: Department
        public async Task<IActionResult> Index()
        {
            return View(await _context.departments.ToListAsync());
        }

        // GET: Department/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentModel = await _context.departments
                .FirstOrDefaultAsync(m => m.DepartmentId == id);
            if (departmentModel == null)
            {
                return NotFound();
            }

            return View(departmentModel);
        }

        // GET: Department/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepartmentId,Name,Budget")] DepartmentModel departmentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departmentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departmentModel);
        }

        // GET: Department/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentModel = await _context.departments.FindAsync(id);
            if (departmentModel == null)
            {
                return NotFound();
            }
            return View(departmentModel);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepartmentId,Name,Budget")] DepartmentModel departmentModel)
        {
            if (id != departmentModel.DepartmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departmentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentModelExists(departmentModel.DepartmentId))
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
            return View(departmentModel);
        }

        // GET: Department/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentModel = await _context.departments
                .FirstOrDefaultAsync(m => m.DepartmentId == id);
            if (departmentModel == null)
            {
                return NotFound();
            }

            return View(departmentModel);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departmentModel = await _context.departments.FindAsync(id);
            if (departmentModel != null)
            {
                _context.departments.Remove(departmentModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentModelExists(int id)
        {
            return _context.departments.Any(e => e.DepartmentId == id);
        }
    }
}
