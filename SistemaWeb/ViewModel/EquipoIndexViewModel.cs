using SistemaWeb.Models;

namespace SistemaWeb.ViewModel
{
    public class EquipoIndexViewModel
    {
        public List<Equipo>? Equipos { get; set; }
        public int numPage { get; set; }
        public int cantidadPaginas { get; set; }
    }
}
