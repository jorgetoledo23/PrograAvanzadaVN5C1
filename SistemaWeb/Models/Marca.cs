using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWeb.Models
{
    public class Marca
    {
        public int Id { get; set; }

        [DisplayName("Nombre de la Marca")]
        public string Name { get; set; }

        public string Imagen { get; set; }

        [NotMapped]
        public IFormFile ImagenFile { get; set; }

        public List<Equipo> Equipos { get; set; }

    }
}
