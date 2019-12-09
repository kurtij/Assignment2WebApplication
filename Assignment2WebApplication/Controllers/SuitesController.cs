using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment2WebApplication.Data;
using Assignment2WebApplication.Models;

namespace Assignment1WebApplication.Controllers
{
    public class SuiteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuiteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Suite
        public async Task<IActionResult> Index()
        {
            return View(await _context.Suite.ToListAsync());
        }

        // GET: Suite/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suite = await _context.Suite
                .FirstOrDefaultAsync(m => m.SuiteId == id);
            if (suite == null)
            {
                return NotFound();
            }

            return View(suite);
        }

        // GET: Suite/Create
        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");

            return View(new Suite());
        }

        // POST: Suite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuiteId,SuiteNumber,SuiteBuzzCode,SqFootage,NumberOfRooms,NumberOfBathrooms")] Suite suite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suite);
        }

        // GET: Suite/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");

            if (id == null)
            {
                return NotFound();
            }

            var suite = await _context.Suite.FindAsync(id);
            if (suite == null)
            {
                return NotFound();
            }
            return View(suite);
        }

        // POST: Suite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SuiteId,SuiteNumber,SuiteBuzzCode,SqFootage,NumberOfRooms,NumberOfBathrooms")] Suite suite)
        {
            if (id != suite.SuiteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuiteExists(suite.SuiteId))
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
            return View(suite);
        }

        // GET: Suite/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");

            if (id == null)
            {
                return NotFound();
            }

            var suite = await _context.Suite
                .FirstOrDefaultAsync(m => m.SuiteId == id);
            if (suite == null)
            {
                return NotFound();
            }

            return View(suite);
        }

        // POST: Suite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suite = await _context.Suite.FindAsync(id);
            _context.Suite.Remove(suite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuiteExists(int id)
        {
            return _context.Suite.Any(e => e.SuiteId == id);
        }
    }
}