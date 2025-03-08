using System;

public class Usuario
{
    private string _nombre;
    private string _apellido;
    private int _dni;
    private string _mail;
    private int _edad; // Cambié edad a _edad
    private string _domicilio;

    // Constructor
    public Usuario(string nombre, string apellido, int dni, string mail, int edad, string domicilio)
    {
        _nombre = nombre;
        _apellido = apellido;
        _dni = dni;
        _mail = mail;
        _edad = edad;
        _domicilio = domicilio;
    }

    // Método para verificar si es mayor de edad
    public bool MayorEdad()
    {
        return _edad >= 18;
    }

    // Método para verificar que el mail es Gmail
    public bool EsGmail()
    {
        return _mail.Contains("@gmail.com"); // Cambié la verificación de Gmail
    }

    //Método para validar que no esté vacío un campo
    public bool NombreVacio()
    {
        return string.IsNullOrWhiteSpace(_nombre); // Verifica si el nombre es nulo o solo contiene espacios en blanco
    }

    // Otros métodos para establecer los valores de las propiedades

    // Método principal
    public static void Main(string[] args)
    {
        // Ejemplo de cómo crear un usuario
        Usuario usuario1 = new Usuario("Juan", "Pérez", 12345678, "juan@gmail.com", 25, "Calle Principal 123");

        // Ejemplo de cómo usar los métodos
        Console.WriteLine(usuario1.NombreVacio());
        Console.WriteLine(usuario1.MayorEdad());
        Console.WriteLine(usuario1.EsGmail());



        Usuario usuario2 = new Usuario("Bauti", "Battaglia", 43405147, "bautista@gmail.com", 22, "Jose Marti 2875");
        Console.WriteLine("El nombre del usuario es: " + usuario2._nombre);
        if (usuario2.MayorEdad())
        {
            Console.WriteLine("Es mayor de edad.");
        }else
        {
            Console.WriteLine("Es menor de edad.");
        }

        if(usuario2.EsGmail())
        {
            Console.WriteLine("Usa Gmail.");
        }else
        {
            Console.WriteLine("No usa Gmail.");
        }

        Console.ReadLine();

    }
}
