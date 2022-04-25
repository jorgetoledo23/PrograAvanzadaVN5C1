using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Ejercicio
{
    public class Mamifero : Animal
    {
        public Boolean PoseePelo { get; set; }
        public Boolean EsHervivoro { get; set; }
        public Boolean EsCarniboro { get; set; }
        public int CantidadPatas { get; set; }

        public override void Alimentarse()
        {
            //Comer
        }

        public override string EmitirSonido()
        {
            return String.Empty;
        }

        public override string InfoDetalladaAnimal()
        {
            return base.InfoBasicaAnimal() + " ";
        }

        public void Sudar()
        {
            //A traves de la glandulas sudoriparas expulsan liquido
        }

        
    }
}
