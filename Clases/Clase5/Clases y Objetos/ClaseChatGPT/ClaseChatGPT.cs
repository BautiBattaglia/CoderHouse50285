using System;

// La clase Producto debería empezar con mayúscula
public class Producto
{
    // Propiedades públicas para acceder a los campos privados
    private int _codigo;
    private string _descripcion; // Corregido el nombre del campo a "_descripcion"
    private double _precioDeCompra;
    private double _precioDeVenta;
    private string _categoria;

    // Constructor por defecto
    public Producto()
    {
        // Inicialización de campos en el constructor por defecto
        _codigo = 0;
        _descripcion = ""; // Cambiado a una cadena vacía en lugar de String.Empty
        _precioDeCompra = 0;
        _precioDeVenta = 0;
        _categoria = ""; // Cambiado a una cadena vacía en lugar de String.Empty
    }

    // Constructor con parámetros
    public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
    {
        // Asignación de valores a los campos
        _codigo = codigo;
        _descripcion = descripcion;
        _precioDeCompra = precioCompra;
        _precioDeVenta = precioVenta;
        _categoria = categoria;
    }

    // Método para verificar si hay precio de venta
    public bool HayPrecioVenta()
    {
        return _precioDeVenta > 0;
    }
}

// La clase ProbarObjetos debería empezar con mayúscula
class ProbarObjetos
{
    static void Main(string[] args)
    {
        /*
        //sin getters ni setters: 
        // Crear instancia de Producto usando constructor por defecto
        Producto testProducto = new Producto();

        // Crear instancia de Producto usando constructor con parámetros
        Producto producto1 = new Producto(1, "pañales", 3.43, 4.12, "Limpieza");

        // Verificar si hay precio de venta para producto1
        if (producto1.HayPrecioVenta())
        {
            Console.WriteLine("El producto está a la venta");
        }
        else
        {
            Console.WriteLine("El producto no fue publicado aún");
        }
         */





    }
}
