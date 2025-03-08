using System;
using System.Collections.Generic;

class Program
{
    static string codigoProducto = "";
    static int cantidadProducto;
    private const string FinVenta = "FIN";
    static decimal totalAPagar = 0.0m;

    // Diccionario para almacenar los precios de los productos
    static Dictionary<string, decimal> preciosProductos = new Dictionary<string, decimal>()
    {
        { "DES", 200 },
        { "JP", 300 },
        { "DET", 250 }
    };

    static void Main()
    {
        Bienvenida();
        while (codigoProducto != FinVenta)
        {
            AgregarProducto();
        }
        if (totalAPagar > 0 && ConfirmarVenta())
        {
            Console.WriteLine($"Gracias por su compra. El total a pagar es: ${totalAPagar}");
        }
        else
        {
            Console.WriteLine("Compra no confirmada o carrito vacío. Finalizando programa.");
        }
    }

    private static void Bienvenida()
    {
        Console.WriteLine("Bienvenido al sistema de ventas.");
    }

    private static void AgregarProducto()
    {
        Console.WriteLine("Ingrese el código del producto o FIN para terminar:");
        codigoProducto = Console.ReadLine().ToUpper(); // Convertir a mayúsculas para hacer coincidir con los códigos del diccionario
        if (codigoProducto != FinVenta)
        {
            Console.WriteLine("Ingrese la cantidad:");
            if (!int.TryParse(Console.ReadLine(), out cantidadProducto) || cantidadProducto < 1)
            {
                Console.WriteLine("Cantidad no válida. Por favor, ingrese un número válido.");
                return;
            }
            // Verificar si el producto está en el diccionario y calcular el precio
            if (preciosProductos.ContainsKey(codigoProducto))
            {
                totalAPagar += preciosProductos[codigoProducto] * cantidadProducto;
            }
            else
            {
                Console.WriteLine("El código del producto no es válido. Por favor, ingrese un código válido.");
            }
        }
    }

    private static bool ConfirmarVenta()
    {
        Console.WriteLine("¿Desea confirmar la venta? SI/NO");
        string ventaConfirmada = Console.ReadLine();
        return !string.IsNullOrWhiteSpace(ventaConfirmada) && ventaConfirmada.ToLower() == "si";
    }
}
