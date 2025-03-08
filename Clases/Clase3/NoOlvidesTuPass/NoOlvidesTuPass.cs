//Se debe validar una contraseña. Max reintentos --> 5 
//Contraseña = "usSystem-2022"
//Si es correcto --> Mensaje de bienvenida
//Si es 5to intento incorrecto --> Bloqueo


string passCorrect = "usSystem-2022";
string pass;
int i = 1;
bool ingreso = true;

Console.WriteLine("Ingrese la contraseña: ");
pass = Console.ReadLine();
while(pass != passCorrect)
{
    Console.WriteLine("Contraseña incorrecta, intento {0}", i);
    ingreso = false;
    Console.WriteLine("Ingrese la contraseña: ");
    pass = Console.ReadLine();
    i++;
    if (pass == passCorrect)
    {
        ingreso = true;
        break;
    }
    if (i == 5)
    {
        break;
    }
}

if (ingreso)
{
    Console.WriteLine("Bienvenido al sistema.");
}
else
{
    Console.WriteLine("Bloqueado.");
}


