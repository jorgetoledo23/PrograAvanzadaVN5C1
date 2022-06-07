using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{

    [Authorize(Roles = "SuperAdministrador, Administrador, Gestion Stock")]
    public class MarcaController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public MarcaController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult MarcaIndex()
        {
            var Marcas = _context.Marcas.ToList();
            return View(Marcas);
        }

        public IActionResult CrearMarca()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearMarca(Marca M)
        {
            if (M.ImagenFile == null) M.Imagen = "no-disponible.png";
            else
            {
                string wwwRootPath = _environment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(M.ImagenFile.FileName);
                string extension = Path.GetExtension(M.ImagenFile.FileName);
                M.Imagen = fileName + DateTime.Now.ToString("ddMMyyyyHHmmss") + extension;

                string path = Path.Combine(wwwRootPath + "/img/" + M.Imagen);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await M.ImagenFile.CopyToAsync(fileStream);
                }
            }
            _context.Add(M);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MarcaIndex));
        }

        public IActionResult EditarMarca(int id)
        {
            var Marca = _context.Marcas.FirstOrDefault(m => m.Id == id);
            return View(Marca);
        }

        [HttpPost]
        public async Task<IActionResult> EditarMarca(Marca M)
        {
            if (M.ImagenFile == null) M.Imagen = "no-disponible.png";
            else
            {
                string wwwRootPath = _environment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(M.ImagenFile.FileName);
                string extension = Path.GetExtension(M.ImagenFile.FileName);
                M.Imagen = fileName + DateTime.Now.ToString("ddMMyyyyHHmmss") + extension;

                string path = Path.Combine(wwwRootPath + "/img/" + M.Imagen);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await M.ImagenFile.CopyToAsync(fileStream);
                }
            }
            _context.Update(M);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MarcaIndex));
        }

        [Authorize(Roles ="Administrador")]
        public async Task<IActionResult> DelMarca(int id)
        {
            var Marca = _context.Marcas.FirstOrDefault(m =>m.Id == id);
            return View(Marca);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public async Task<IActionResult> DelMarca(Marca Marca)
        {
            _context.Remove(Marca);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MarcaIndex));
        }

        public async Task<IActionResult> DetailMarca(int id)
        {
            var Marca = _context.Marcas.FirstOrDefault(m => m.Id == id);
            return View(Marca);
        }










    }
}
