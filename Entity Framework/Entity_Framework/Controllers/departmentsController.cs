using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entity_Framework.Models;

namespace Entity_Framework.Controllers
{
    public class departmentsController : Controller
    {
        private readonly myapp _context;

        public departmentsController(myapp context)
        {
            _context = context;
        }

        // GET: departments
        public async Task<IActionResult> Index()
        {
              return View(await _context.departments.ToListAsync());
        }

        // GET: departments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.departments == null)
            {
                return NotFound();
            }

            var departments = await _context.departments
                .FirstOrDefaultAsync(m => m.department_name == id);
            if (departments == null)
            {
                return NotFound();
            }

            return View(departments);
        }

        // GET: departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("department_id,department_name")] departments departments)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(departments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            return View(departments);
        }

        // GET: departments/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.departments == null)
            {
                return NotFound();
            }

            var departments = await _context.departments.FindAsync(id);
            if (departments == null)
            {
                return NotFound();
            }
            return View(departments);
        }

        // POST: departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("department_id,department_name")] departments departments)
        {
            if (id != departments.department_name)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!departmentsExists(departments.department_name))
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
            return View(departments);
        }

        // GET: departments/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.departments == null)
            {
                return NotFound();
            }

            var departments = await _context.departments
                .FirstOrDefaultAsync(m => m.department_name == id);
            if (departments == null)
            {
                return NotFound();
            }

            return View(departments);
        }

        // POST: departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.departments == null)
            {
                return Problem("Entity set 'myapp.departments'  is null.");
            }
            var departments = await _context.departments.FindAsync(id);
            if (departments != null)
            {
                _context.departments.Remove(departments);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool departmentsExists(string id)
        {
          return _context.departments.Any(e => e.department_name == id);
        }
    }
}
