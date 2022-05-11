using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class EquipoController : Controller
    {
        private readonly AppDbContext _context;

        public EquipoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult EquipoIndex()
        {
            var Equipos = _context.Equipos
                .Include(e => e.Marca)
                .Include(e => e.Linea)
                .Include(e => e.Clase)
                .Include(e => e.Procesador)
                .ToList();

            return View(Equipos);
        }

        public IActionResult Create()
        {
            ViewData["Marca"] = new SelectList(_context.Marcas.ToList(), "Id", "Name");
            return View();
        }
    }
}
