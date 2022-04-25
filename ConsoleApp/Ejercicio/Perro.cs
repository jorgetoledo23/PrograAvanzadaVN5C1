using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejercicio
{
    public class Perro : Mamifero
    {

        public static string Especie { get; } = "Canino";


        public override string EmitirSonido()
        {
            return "Ladrar";
        }
    }
}
