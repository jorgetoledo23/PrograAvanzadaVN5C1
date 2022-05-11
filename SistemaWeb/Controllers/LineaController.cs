using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class LineaController : Controller
    {
        private readonly AppDbContext _context;

        public LineaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Linea
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lineas.ToListAsync());
        }

        // GET: Linea/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lineas == null)
            {
                return NotFound();
            }

            var linea = await _context.Lineas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linea == null)
            {
                return NotFound();
            }

            return View(linea);
        }

        // GET: Linea/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Linea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(Linea linea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linea);
        }

        // GET: Linea/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lineas == null)
            {
                return NotFound();
            }

            var linea = await _context.Lineas.FindAsync(id);
            if (linea == null)
            {
                return NotFound();
            }
            return View(linea);
        }

        // POST: Linea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] Linea linea)
        {
            if (id != linea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LineaExists(linea.Id))
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
            return View(linea);
        }

        // GET: Linea/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lineas == null)
            {
                return NotFound();
            }

            var linea = await _context.Lineas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (linea == null)
            {
                return NotFound();
            }

            return View(linea);
        }

        // POST: Linea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lineas == null)
            {
                return Problem("Entity set 'AppDbContext.Lineas'  is null.");
            }
            var linea = await _context.Lineas.FindAsync(id);
            if (linea != null)
            {
                _context.Lineas.Remove(linea);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LineaExists(int id)
        {
          return (_context.Lineas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
