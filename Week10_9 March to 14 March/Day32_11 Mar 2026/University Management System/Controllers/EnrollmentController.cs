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
    public class EnrollmentController : Controller
    {
        private readonly UniversityManagementDBcontext _context;

        public EnrollmentController(UniversityManagementDBcontext context)
        {
            _context = context;
        }

        // GET: Enrollment
        public async Task<IActionResult> Index()
        {
            return View(await _context.enrollments.ToListAsync());
        }

        // GET: Enrollment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollmentModel = await _context.enrollments
                .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            if (enrollmentModel == null)
            {
                return NotFound();
            }

            return View(enrollmentModel);
        }

        // GET: Enrollment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enrollment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollmentId,StudentId,CourseId,Grade")] EnrollmentModel enrollmentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrollmentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enrollmentModel);
        }

        // GET: Enrollment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollmentModel = await _context.enrollments.FindAsync(id);
            if (enrollmentModel == null)
            {
                return NotFound();
            }
            return View(enrollmentModel);
        }

        // POST: Enrollment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnrollmentId,StudentId,CourseId,Grade")] EnrollmentModel enrollmentModel)
        {
            if (id != enrollmentModel.EnrollmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollmentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollmentModelExists(enrollmentModel.EnrollmentId))
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
            return View(enrollmentModel);
        }

        // GET: Enrollment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollmentModel = await _context.enrollments
                .FirstOrDefaultAsync(m => m.EnrollmentId == id);
            if (enrollmentModel == null)
            {
                return NotFound();
            }

            return View(enrollmentModel);
        }

        // POST: Enrollment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrollmentModel = await _context.enrollments.FindAsync(id);
            if (enrollmentModel != null)
            {
                _context.enrollments.Remove(enrollmentModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrollmentModelExists(int id)
        {
            return _context.enrollments.Any(e => e.EnrollmentId == id);
        }
    }
}
