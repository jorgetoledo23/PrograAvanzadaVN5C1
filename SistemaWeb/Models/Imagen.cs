using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWeb.Models
{
    public class Imagen
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }

        [NotMapped]
        [Display(Name = "Imagen")]
        public IFormFile ImagenFile { get; set; }

        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }

    }
}
