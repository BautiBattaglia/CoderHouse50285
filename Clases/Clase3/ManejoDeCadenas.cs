//MANEJO DE CADENAS

//Para iniciar una cadena vacía:
//string cadVacia = String.Empty;

//Siempre conviene inicializar las variables

//Cadena nula:
string cadenaNula = null;
string cadenaVacia = string.Empty;
string cadenaSaludo = "Hola, soy una cadena";

Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia);

//NO ES LO MISMO UNA CADENA NULA QUE UNA CADENA VACÍA
if (cadenaNula == cadenaVacia)
{
    Console.WriteLine("Las cadenas son iguales!");
}
else
{
    Console.WriteLine("Las cadenas no son iguales!");
}


//Función length
//Console.WriteLine(cadenaNula.Length); ROMPE
Console.WriteLine(cadenaVacia.Trim().Length); //Función TRIM, lo que hace es borrar los espacios del principio y del final.
Console.WriteLine(cadenaSaludo.Length);

//ToUpper y ToLower
Console.WriteLine("Mayúscula: " + cadenaSaludo.ToUpper());
Console.WriteLine("Minúscula: " + cadenaSaludo.ToLower());

//ToString: convierte la información en la cadena, a una variable string. Sirve para concatenar en texto.
int numeroEntero = 22;
double numeroConDecimales = 1.88;
bool booleano = true;

Console.WriteLine(numeroEntero.ToString() + numeroConDecimales.ToString() + booleano.ToString());

//Contains
//Cadena1.Contains(Cadena2);

//Parse: transformar de string a numérico (int,float,double)
Console.WriteLine("Ingrese el valor a parsear: ");
string cadena = Console.ReadLine();
double constante = 0.5;
double numeroEnCadenaConvertidoADouble;
double sumaConNumeroDouble;

if (string.IsNullOrEmpty(cadena))
{
    Console.WriteLine("La cadena no se puede parsear, ya que está vacía");
}
else
{
    numeroEnCadenaConvertidoADouble = double.Parse(cadena);
    sumaConNumeroDouble = numeroEnCadenaConvertidoADouble + constante;
    Console.WriteLine("El resultado es: " + sumaConNumeroDouble);
}








