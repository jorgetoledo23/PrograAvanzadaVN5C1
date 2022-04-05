using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }// Primary Key

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono{ get; set; }
        [Required]
        public string Rut{ get; set; }
        public string Direccion{ get; set; }
        public string Comuna{ get; set; }
        public DateTime FechaNacimiento{ get; set; }





    }
}
