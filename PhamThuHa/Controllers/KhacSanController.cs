using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamThuHa.Models;

namespace PhamThuHa.Controllers
{
    public class KhacSanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KhacSanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KhacSan
        public async Task<IActionResult> Index()
        {
              return _context.KhachSan != null ? 
                          View(await _context.KhachSan.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.KhachSan'  is null.");
        }

        // GET: KhacSan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.KhachSan == null)
            {
                return NotFound();
            }

            var khachSan = await _context.KhachSan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (khachSan == null)
            {
                return NotFound();
            }

            return View(khachSan);
        }

        // GET: KhacSan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhacSan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameStudent,DiachiStudent")] KhachSan khachSan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachSan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachSan);
        }

        // GET: KhacSan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.KhachSan == null)
            {
                return NotFound();
            }

            var khachSan = await _context.KhachSan.FindAsync(id);
            if (khachSan == null)
            {
                return NotFound();
            }
            return View(khachSan);
        }

        // POST: KhacSan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameStudent,DiachiStudent")] KhachSan khachSan)
        {
            if (id != khachSan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachSan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachSanExists(khachSan.Id))
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
            return View(khachSan);
        }

        // GET: KhacSan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.KhachSan == null)
            {
                return NotFound();
            }

            var khachSan = await _context.KhachSan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (khachSan == null)
            {
                return NotFound();
            }

            return View(khachSan);
        }

        // POST: KhacSan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.KhachSan == null)
            {
                return Problem("Entity set 'ApplicationDbContext.KhachSan'  is null.");
            }
            var khachSan = await _context.KhachSan.FindAsync(id);
            if (khachSan != null)
            {
                _context.KhachSan.Remove(khachSan);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachSanExists(int id)
        {
          return (_context.KhachSan?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
