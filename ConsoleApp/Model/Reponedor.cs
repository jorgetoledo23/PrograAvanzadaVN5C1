using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class Reponedor : Persona
    {
        public int NumeroCredencial { get; set; }

        public override string MarcarIngreso()
        {
            return $"Reponedor Numero Credencial: {NumeroCredencial}, marca ingreso a las: {DateTime.Now}";
        }

        public override string MarcarSalida()
        {
            throw new NotImplementedException();
        }
    }
}
