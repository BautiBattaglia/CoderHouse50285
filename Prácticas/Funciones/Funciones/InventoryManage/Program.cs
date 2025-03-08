//Gestión de una tienda pequeña
//Permitir agregar productos a un inventario, eliminar y mostrar el inventario actual
//Estructura de producto: ID, Nombre y Cantidad
//Funciones: agregarProducto, eliminarProducto y mostrarInventario
//Validar los ingresos del usuario
//Manejo de errores


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var inventario = new Dictionary<int, Producto>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Agregar producto");
            Console.WriteLine("2 - Eliminar producto");
            Console.WriteLine("3 - Mostrar inventario");
            Console.WriteLine("4 - Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarProducto(inventario);
                    break;
                case 2:
                    EliminarProducto(inventario);
                    break;
                case 3:
                    MostrarInventario(inventario);
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    struct Producto
    {
        public int Id;
        public string Nombre;
        public int Cantidad;

        public Producto(int id, string nombre, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }

    static void AgregarProducto(Dictionary<int, Producto> inventario)
    {
        // Implementar la lógica para agregar un producto al diccionario
    }

    static void EliminarProducto(Dictionary<int, Producto> inventario)
    {
        // Implementar la lógica para eliminar o decrementar un producto del diccionario
    }

    static void MostrarInventario(Dictionary<int, Producto> inventario)
    {
        // Implementar la lógica para mostrar todos los productos en el diccionario
    }
}
