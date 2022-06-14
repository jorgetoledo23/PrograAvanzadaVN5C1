using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Models;
using System.Security.Cryptography;

namespace SistemaWeb.Controllers
{
    [Authorize(Roles = "SuperAdministrador")]
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult GestionUsuarios()
        {
            return View(_context.Usuarios.ToList());
        }

        public IActionResult CreateUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario(RegistroViewModel Rvm)
        {
            //TODO: Validar que no se repita el Username y Correo en el crear Usuario
            if (ModelState.IsValid)
            {
                Usuario? U = _context.Usuarios.Where(x => x.Username == Rvm.Username).FirstOrDefault();
                if (U == null)
                {
                    U = new Usuario();
                    U.Name = Rvm.Name;
                    U.Email = Rvm.Email;
                    U.Rol = Rvm.Rol;
                    U.Username = Rvm.Username;

                    CreatePasswordHash(Rvm.Password, out byte[] Hash, out byte[] salt);

                    U.PasswordHash = Hash;
                    U.PasswordSalt = salt;

                    _context.Usuarios.Add(U);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(GestionUsuarios));
                }
                else
                {
                    //Username Existe
                    ModelState.AddModelError(String.Empty, "Username ya Existe!");
                    return View(Rvm);
                }
                
            }
            else
            {
                return View(Rvm);
            }
            
        }

        public async Task<IActionResult> EditUsuario(Guid userid)
        {
            var Usuario = await _context.Usuarios.FindAsync(userid);
            if (Usuario == null) return NotFound();
            UserEditViewModel Uevm = new UserEditViewModel()
            {
                Username = Usuario.Username,
                Email = Usuario.Email,
                Id = userid,
                Name = Usuario.Name,
                Rol = Usuario.Rol
            };
            return View(Uevm);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsuario(UserEditViewModel? Uevm)
        {
            //TODO: Validar que no se repita el Username y Correo en el Editar
            if (!ModelState.IsValid) return View(Uevm);
            var Usuario = await _context.Usuarios.FindAsync(Uevm.Id);
            if (Usuario == null) return NotFound();

            Usuario.Username = Uevm.Username;
            Usuario.Email = Uevm.Email;
            Usuario.Name = Uevm.Name;
            Usuario.Rol = Uevm.Rol;

            CreatePasswordHash(Uevm.Password, out byte[] Hash, out byte[] Salt);
            Usuario.PasswordHash = Hash;
            Usuario.PasswordSalt = Salt;

            _context.Usuarios.Update(Usuario);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(GestionUsuarios));
        }





        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

    }
}
