//For (se repite la condición de fin)

//ejemplo for


int cantidadNotas = 0;
double promedio = 0;
double nota = 0;
double sumaNotas = 0;

Console.WriteLine("Ingrese la cantidad de notas a cargar: ");
cantidadNotas = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidadNotas; i++)
{
    Console.WriteLine("Ingrese nota {0}: ", i);
    nota = double.Parse(Console.ReadLine());
    sumaNotas = sumaNotas + nota;
}

promedio = sumaNotas / cantidadNotas;
Console.WriteLine("El promedio es: " + promedio);

