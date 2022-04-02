/* namespace => Espacio de Nombres 
 * Sirve para agrupar Class en un mismo contexto 
 Por ejemplo namespace Animales agruparia clases Perro, Gato, Raton */
namespace PrograAvanzadaVN5C1
{
    /* Internal grado de Privacidad de la Clase 
     internal => Clase sera visible para todas las clases que formen
    parte del mismo ensamblado
     */
    public class Persona
    {
        /* Plantillas / Moldes para crear Objetos */
        /* Un objeto es una Instancia */
        /* Instancia es la existencia de algo */

        /* La clase se conforma de Campos
         Los campos pueden ser Atributos, Metodos, o Eventos
         */

        /* Todas las Clases heredan de la Clase Object */

        /*Campos Privados */
        private string _rut;
        private string _name;
        private string _apellido;
        private int _edad;

        /* Porperties prop => propiedades */
        public string Rut { get; set; }
        public string Name => $"{_name} {_apellido}";
        public int Edad {
            get { return _edad; }
            set {
                if (value < 0 || Edad > 150)
                {
                    throw new ArgumentOutOfRangeException
                        ("La edad debe estar entre 0 y 150");
                }
                else
                {
                    _edad = value;
                }
            }
        }


        /* Constructor ctor */
        public Persona(string rut)
        {
            _rut = rut;
        }
        public Persona(string rut, string nombre, string apellido)
        {
            _rut = rut;
            _name = nombre;
            _apellido = apellido;
        }
        public Persona(int rut)
        {
            
        }

        /* Metodos 
         Representan comportamiento */

        //Metodos simples VOID
        public void Caminar()
        {
            _edad = 0;
        }

        //Metodos con retorno
        public string verEdad()
        {
            return "aaa";
        }

        


    }
}
