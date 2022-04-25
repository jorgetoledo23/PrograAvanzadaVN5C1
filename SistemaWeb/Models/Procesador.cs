namespace SistemaWeb.Models
{
    public class Procesador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gen { get; set; }
        public string Marca { get; set; }

        public List<Equipo> Equipos { get; set; }


    }
}
