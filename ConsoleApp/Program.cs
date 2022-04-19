using ConsoleApp.Model;

Persona Persona = new Persona()
{
    Id = 1,
    Name = "Juan",
    LastName = "Perez"
};
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