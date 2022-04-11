using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class PersonaController : Controller
    {
        private readonly AppDbContext _context;

        public PersonaController(AppDbContext context)
        {
            _context = context;
        }

        //PETICION GET
        public IActionResult AddPersona() { return View(); }
        public IActionResult ListaPersonas() { return View(_context.Personas.ToList());} 
        


        //PETICION POST
        [HttpPost]
        public async Task<RedirectToActionResult> AddPersona(Persona P) {
            _context.Add(P);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListaPersonas));
        }

    }
}
