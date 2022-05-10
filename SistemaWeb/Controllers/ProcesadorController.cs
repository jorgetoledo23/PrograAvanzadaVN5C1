#nullable disable
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
    public class ProcesadorController : Controller
    {
        private readonly AppDbContext _context;

        public ProcesadorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Procesador
        public async Task<IActionResult> ProcesadorIndex()
        {
            return View(await _context.Procesadores.ToListAsync());
        }

        // GET: Procesador/Details/5
        public async Task<IActionResult> DetailProcesador(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesador = await _context.Procesadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procesador == null)
            {
                return NotFound();
            }

            return View(procesador);
        }

        // GET: Procesador/Create
        public IActionResult CrearProcesador()
        {
            return View();
        }

        // POST: Procesador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearProcesador(Procesador procesador)
        {
            _context.Add(procesador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ProcesadorIndex));
        }

        // GET: Procesador/Edit/5
        public async Task<IActionResult> EditarProcesador(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesador = await _context.Procesadores.FindAsync(id);
            if (procesador == null)
            {
                return NotFound();
            }
            return View(procesador);
        }

        // POST: Procesador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarProcesador(Procesador procesador)
        {
            _context.Update(procesador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ProcesadorIndex));
        }

        // GET: Procesador/Delete/5
        public async Task<IActionResult> DelProcesador(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesador = await _context.Procesadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procesador == null)
            {
                return NotFound();
            }

            return View(procesador);
        }

        // POST: Procesador/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DelProcesador(int id)
        {
            var procesador = await _context.Procesadores.FindAsync(id);
            _context.Procesadores.Remove(procesador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ProcesadorIndex));
        }

        private bool ProcesadorExists(int id)
        {
            return _context.Procesadores.Any(e => e.Id == id);
        }
    }
}
