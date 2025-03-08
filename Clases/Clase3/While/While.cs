//While (mientras que)

//Ejemplo
using System.ComponentModel;

Console.WriteLine("Ingrese la contraseña: ");
string pass = Console.ReadLine();

while (!pass.Equals("Co123"))
{
    Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
    pass = Console.ReadLine();
}
Console.WriteLine("Bienvenido a CoderHouse");