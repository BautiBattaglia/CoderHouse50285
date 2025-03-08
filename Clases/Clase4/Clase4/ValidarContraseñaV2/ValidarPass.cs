//Validar acceso de contraseña utilizando funciones
//Cuando es correcta debe decir "**** es correcta"
//Si llega a 5 reintentos, se debe bloquear


string passCorrect = "123456";
string pass;
int max = 2;
bool ingreso = false;


solicitarPass();

if (pass == passCorrect)
{
    ingreso = true;
}

while (pass != passCorrect)
{
    Console.WriteLine("Pass incorrecta. Intento {0}", max);
    max++;
    solicitarPass();
    if (pass == passCorrect)
    {
        ingreso = true;
        break;
    }
    if (max == 6)
    {
        Console.WriteLine("Bloqueado.");
        break;
    }

}


if (ingreso)
{
    bienvenido();
}


void solicitarPass()
{
    Console.WriteLine("Ingrese su contraseña: ");
    pass = Console.ReadLine();
}

void bienvenido()
{
    Console.WriteLine("Bienvenido al sistema.");
}