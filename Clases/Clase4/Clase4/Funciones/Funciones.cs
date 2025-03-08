//FUNCIONES

//Se utilizan para reutilizar código y evitar duplicidades
//Permiten el cowork y mejora la legibilidad del código

//EJEMPLO SALUDAR

saludar();
saludar();

void saludar()
{
    Console.WriteLine("Buen día!");
}


//EJEMPLO SUMAR

//Console.WriteLine(sumar(1, 3));


Console.WriteLine("Ingrese los números a sumar: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int resultado = sumar(num1, num2);
Console.WriteLine("Resultado: " + resultado);


int sumar (int numero1, int numero2)
{
    return numero1 + numero2;
}

