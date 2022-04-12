namespace ConsoleApp.Model
{
    public class Empleado
    {
        //Members (Miembros) =>
        //Propiedades que definen caracteristicas
        //Metodos que definen comportamiento
        //Eventos* controlan interaccion

        public string Rut
        {
            get { return Rut; }
            set { Rut = value; }
        }
        // => public string Rut { get; set; }

        private int _Edad;
        public int Edad
        {
            get { return _Edad; }
            set {
                if (value > 0 && value < 150)
                {
                    _Edad = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException
                        ("Edad debe estar entre 0 y 150");
                }
            }
        }






        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
