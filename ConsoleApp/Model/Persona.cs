using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        

        public virtual string MarcarIngreso() => $"Empleado Id: {Id} ingresa a las: " +
            $"{DateTime.Now}";

        public override string ToString() => $"Empleado ID: {Id}, " +
            $"Name: {Name} {LastName}";

        public abstract string MarcarSalida();

    }
}
