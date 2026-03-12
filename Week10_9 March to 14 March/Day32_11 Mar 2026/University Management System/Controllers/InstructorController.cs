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
    public class InstructorController : Controller
    {
        private readonly UniversityManagementDBcontext _context;

        public InstructorController(UniversityManagementDBcontext context)
        {
            _context = context;
        }

        // GET: Instructor
        public async Task<IActionResult> Index()
        {
            return View(await _context.instructors.ToListAsync());
        }

        // GET: Instructor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorModel = await _context.instructors
                .FirstOrDefaultAsync(m => m.InstructorId == id);
            if (instructorModel == null)
            {
                return NotFound();
            }

            return View(instructorModel);
        }

        // GET: Instructor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instructor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstructorId,Name,Department")] InstructorModel instructorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instructorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instructorModel);
        }

        // GET: Instructor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorModel = await _context.instructors.FindAsync(id);
            if (instructorModel == null)
            {
                return NotFound();
            }
            return View(instructorModel);
        }

        // POST: Instructor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstructorId,Name,Department")] InstructorModel instructorModel)
        {
            if (id != instructorModel.InstructorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instructorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstructorModelExists(instructorModel.InstructorId))
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
            return View(instructorModel);
        }

        // GET: Instructor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorModel = await _context.instructors
                .FirstOrDefaultAsync(m => m.InstructorId == id);
            if (instructorModel == null)
            {
                return NotFound();
            }

            return View(instructorModel);
        }

        // POST: Instructor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instructorModel = await _context.instructors.FindAsync(id);
            if (instructorModel != null)
            {
                _context.instructors.Remove(instructorModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstructorModelExists(int id)
        {
            return _context.instructors.Any(e => e.InstructorId == id);
        }
    }
}
