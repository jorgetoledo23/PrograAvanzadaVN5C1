using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWeb.Models
{
    public class Equipo
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }
        public string Ram { get; set; }
        public string Disco { get; set; }
        public string NSerie { get; set; }
        public string NModel { get; set; }
        public string Accesorios { get; set; }

        
        public DateTime FechaAdquisicion { get; set; }
        public DateTime Garantia { get; set; }



        


        //Claves Foraneas
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public int ClaseId { get; set; }
        public Clase Clase { get; set; }
        public int LineaId { get; set; }
        public Linea Linea { get; set; }
        public int ProcesadorId { get; set; }
        public Procesador Procesador { get; set; }


        public List<Imagen> Imagenes { get; set; }







    }
}
