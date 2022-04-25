namespace SistemaWeb.Models
{
    public class Linea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Equipo> Equipos { get; set; }
    }
}
