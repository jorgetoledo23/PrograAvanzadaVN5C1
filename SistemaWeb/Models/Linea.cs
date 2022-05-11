using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Linea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripcion es requerida")]
        public string Descripcion { get; set; }
        public virtual List<Equipo>? Equipos { get; set; }
    }
}
