//Variables

int pass = 123456;
int passIngresado;
string perfilIngresad0;

Console.WriteLine("Ingrese su perfil: ");
perfilIngresad0 = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña: ");
passIngresado = Convert.ToInt32(Console.ReadLine());

if (pass == passIngresado)
{
    switch (perfilIngresad0)
    {
        case "A":
            Console.WriteLine("Bienvenido Admin");
            break;
        case "U":
            Console.WriteLine("Bienvenido Usuario");
            break;
        default:
            Console.WriteLine("Bienvenido sin perfil definido");
            break;
    }
}
else
{
    Console.WriteLine("Contraseña incorrecta.");
}