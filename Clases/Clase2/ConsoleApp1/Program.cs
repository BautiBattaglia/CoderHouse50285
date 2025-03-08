//Estructura SWITCH

using System;

string categoria;

Console.WriteLine("Ingrese la categoría A, B, C o D");

categoria = Console.ReadLine();

switch(categoria)
{
    //De ambas formas sale por acá A o D
    case "A":
    case "D":
        Console.WriteLine("Empleado administrativo");
        break;
    case "B":
        Console.WriteLine("Empleado administrativo");
        break;
    case "C":
        Console.WriteLine("Empleado administrativo");
        break;
    default:
        Console.WriteLine("No tiene categoría");
        break
}


//Ejercicio escuela

string comision;
int calificacion;

Console.Writeline("Bienvenidos!");
Console.WriteLine("Ingrese comision: (A, B o C)");
comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno mañana.");
        break;
    case "B":
        Console.WriteLine("Turno tarde.");
        break;
    case "C":
        Console.WriteLine("Turno noche.");
        break;
    default:
        Console.WriteLine("Turno rotativo.");
        break;
}


Console.WriteLine("Ingrese la nota del alumno: ");

calificacion = Console.ReadLine();

if (calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}
else if(calificacion >= 4 && calificacion < 7)
{
    Console.Writeline("Cursada aprobada");
}
else if (calificacion > 7 && calificacion <= 10)
{
    Console.WriteLine("Promocionado");
}






