namespace SistemaWeb.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }

        //Prodpiedad de Navegacion
        public List<Equipo> Equipos { get; set; }

    }
}
