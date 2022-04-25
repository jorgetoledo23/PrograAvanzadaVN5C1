using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejercicio
{
    public abstract class Animal
    {
        public string NombreCientifico { get; set; }
        public string NombreComun { get; set; }
        public string Especie { get; set; }

        public abstract void Alimentarse();
        public abstract string EmitirSonido();
        public virtual void Respirar()
        {
            //Absorbe Oxigeno
        }

        public string InfoBasicaAnimal()
        {
            return $"Nombre Cientifico: {NombreCientifico}, Nombre Comun: {NombreComun}, Especie: {Especie}";
        }

        public abstract string InfoDetalladaAnimal();


    }
}
