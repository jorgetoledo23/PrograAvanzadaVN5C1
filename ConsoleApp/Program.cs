using ConsoleApp.Model;

Console.WriteLine("Hello, World!");

int i;
int j = 10; //Asignacion
string Name = "Jorge";
bool Bandera = false; // true
double PI = Math.PI;
char Caracter = 'a';

var Caracter2 = 'b';
var PI2 = Math.PI;

string[] paises = new string[10];
paises[0] = "Chile";

List<string> paises2 = new List<string>();
paises2.Add("Chile");
paises2.ForEach(pais =>
{
    Console.WriteLine(pais);
});

if (paises2.Contains("Chile"))
{
    //Hacer Algo
}
string? paisBuscado = paises2.Find(pais => pais.Equals("Bolivia"));
//paisBuscado = null;

//Posibilidad de tener un valor null;
int edad = 10;
int? edad2 = null;



