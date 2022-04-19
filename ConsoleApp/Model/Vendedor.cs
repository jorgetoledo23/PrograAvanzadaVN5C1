using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class Vendedor : Persona
    {
        public int CodigoVendedor { get; set; }

        public override string MarcarIngreso()
        {
            return $"Vendedor Codigo: {CodigoVendedor}, marca ingreso a las: {DateTime.Now}";
        }

        public override string MarcarSalida()
        {
            throw new NotImplementedException();
        }
    }
}
