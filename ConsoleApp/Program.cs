using ConsoleApp.Ejercicio;
using ConsoleApp.Model;


Vendedor Vendedor = new Vendedor()
{
    Id = 2,
    Name = "Andrea",
    LastName = "Gonzalez",
    CodigoVendedor = 12341234
};
Reponedor Reponedor = new Reponedor()
{
    Id = 3,
    Name = "Julia",
    LastName = "Amestica",
    NumeroCredencial = 234567812
};
Contratista Contratista = new Contratista()
{
    Id = 4,
    Name = "Roberto",
    LastName = "Millan",
    NumeroContrato = 53423121
};

Console.WriteLine(Vendedor.MarcarIngreso());
Console.WriteLine(Reponedor.MarcarIngreso());
Console.WriteLine(Contratista.MarcarIngreso());



Perro P = new Perro();
P.PoseePelo = true;
P.EsCarniboro = true;
P.EsHervivoro = false;
P.CantidadPatas = 4;
P.NombreCientifico = "Canino";
P.NombreComun = "Cancervero";

Perro P2 = new Perro();
P2.PoseePelo = true;
P2.EsCarniboro = true;
P2.EsHervivoro = false;
P2.CantidadPatas = 4;
P2.NombreCientifico = "Canino";
P2.NombreComun = "Cancervero";


Console.WriteLine(Perro.Especie);

