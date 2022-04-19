using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class Contratista : Persona
    {
        public int NumeroContrato { get; set; }

        public override string MarcarIngreso()
        {
            return $"Contratista N° Contrato: {NumeroContrato}, Firma libro a las {DateTime.Now}";
        }

        public override string MarcarSalida()
        {
            throw new NotImplementedException();
        }
    }
}
