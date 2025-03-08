//Continue
//Se utiliza cuando procesas un bloque de código, queres incrementar el ciclo, antes de ejecutar todo lo que queda de ese bloque. Reinicia el bloque.
//Diferente del break

//Calculadora de promedio 3.0

int cantidadNotas = 0;
double nota = 0;
double promedio = 0;
double suma = 0;
bool aplazado = false;

Console.WriteLine("Ingrese la cantidad de notas a cargar:");
cantidadNotas = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidadNotas; i++)
{
    Console.WriteLine("Ingrese la nota {0}: ", i);
    nota = double.Parse(Console.ReadLine());
    if (nota <= 2)
    {
        aplazado = true;
        break;
    }
    if (nota > 2 && nota < 4)
    {
        cantidadNotas--; //se resta 1 a la cantidad de notas, para que no afecte el promedio
        continue;
    }
    suma = suma + nota;
}

if (aplazado == true)
{
    Console.WriteLine("Aplazado");
}
else
{
    promedio = suma / cantidadNotas;
    Console.WriteLine("Promedio: " + promedio);
}


//Clasificador de números enteros con un While

Console.WriteLine("Ingrese un número para clasificar:");
Console.WriteLine("Para salir ingrese 0.");

int n;
n = int.Parse(Console.ReadLine());

while (n != 0)
{
    if (n > 0)
    {
        Console.WriteLine("Número positivo.");
    }
    else
    {
        Console.WriteLine("Número negativo.");
    }
    Console.WriteLine("Ingrese un número para clasificar:");
    Console.WriteLine("Para salir ingrese 0.");
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine("Bucle finalizado.");