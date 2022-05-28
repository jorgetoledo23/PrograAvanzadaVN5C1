using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Models;
using SistemaWeb.ViewModel;

namespace SistemaWeb.Controllers
{
    public class EquipoController : Controller
    {
        private readonly AppDbContext _context;

        public EquipoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult EquipoIndex(int numPage)
        {
            EquipoIndexViewModel equipoIndexViewModel = new EquipoIndexViewModel();

            var Equipos = _context.Equipos
                .Include(e => e.Marca)
                .Include(e => e.Linea)
                .Include(e => e.Clase)
                .Include(e => e.Procesador)
                .ToList();

            int muestra = 10;
            int totalEquipos = Equipos.Count;

            //Total de Paginas
            if (totalEquipos % muestra == 0) equipoIndexViewModel.cantidadPaginas = totalEquipos / muestra;
            else equipoIndexViewModel.cantidadPaginas = totalEquipos / muestra + 1;
            //Pagina Actual
            if (numPage == 0) equipoIndexViewModel.numPage = 1;
            else equipoIndexViewModel.numPage = numPage;
            //Equipos
            equipoIndexViewModel.Equipos = _context.Equipos
                .Skip((equipoIndexViewModel.numPage - 1) * muestra)
                .Take(muestra)
                .ToList();
            return View(equipoIndexViewModel);
        }

        public IActionResult Create()
        {
            ViewData["Marca"] = new SelectList(_context.Marcas.ToList(), "Id", "Name");
            ViewData["Clase"] = new SelectList(_context.Clases.ToList(), "Id", "Name");
            ViewData["Procesador"] = new SelectList(_context.Procesadores.ToList(), "Id", "Name");
            ViewData["Linea"] = new SelectList(_context.Lineas.ToList(), "Id", "Descripcion");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Equipo E)
        {
            if (ModelState.IsValid)
            {
                _context.Add(E);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EquipoIndex));
            }
            return View(E);
        }
    }
}
