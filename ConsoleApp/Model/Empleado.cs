namespace ConsoleApp.Model
{
    public class Empleado
    {
        //Members (Miembros) =>
        //Propiedades que definen caracteristicas
        //Metodos que definen comportamiento
        //Eventos* controlan interaccion
        
        public string Rut { get; set; }

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


        public Empleado()
        {
            //Metodo que se ejecuta cuando creo la Instancia => new Empleado();
        }

        public Empleado(string Rut, string Nombre, string Apellido)
        {
            this.Rut = Rut;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }


        //private => Grado de Acceso
        //string => Tipo de Retorno
        //MarcarEntrada() => Nombre del Metodo
        public string MarcarEntrada() {
            return $"Empleado {Rut}, {Nombre} {Apellido}, Ingresa a las {DateTime.Now}";
        }


    }
}
