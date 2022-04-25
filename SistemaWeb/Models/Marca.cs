namespace SistemaWeb.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Equipo> Equipos { get; set; }

    }
}
