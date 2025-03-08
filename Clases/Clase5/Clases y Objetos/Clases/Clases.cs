//Clases
//siempre debe empezar con mayúscula
//tiene atributos y métodos.
//MODIFICADOR DE ACCESO:
//public: acceso desde cualquier clase. Desde cualquier solución.
//private: solamente desde la misma clase.
//protected: solamente de la clase o de una clase derivada de la misma clase
//internal: acceso desde cualquier clase dentro del mismo proyecto

using System.Runtime.CompilerServices;

public class Producto
{
    //sin getters and setters
    private int _codigo;
    private string _description;
    private double _precioDeCompra;
    private double _precioDeVenta;
    private string _categoria;



    //constructor por defecto
    public Producto()
    {
        _codigo = 0;
        _description = String.Empty;
        _precioDeCompra = 0;
        _precioDeVenta = 0;
        _categoria = String.Empty;
    }


    //Definición de la clase completa
    public int codigo { get; set; }
    public string description { get; set; }
    public double precioDeCompra { get; set; }
    public double precioDeVenta { get; set; }
    public string categoria
    {
        get
        {
            if (!string.IsNullOrEmpty(this._categoria))
                return this._categoria;
            else return "Sin categoría";
        }
        set
        {
            this._categoria = value;
        }
    }


    public Producto(int codigo, string description, double precioCompra, double precioVenta, string categoria)
    {
        this._codigo = codigo;
        this._description = description;
        this._precioDeCompra = precioCompra;
        this._precioDeVenta = precioVenta;
        this._categoria = categoria;
    }
    public bool hayPrecioVenta()
    {
        return this._precioDeVenta > 0;
    }
}

//Instancia desde otra clase

class ProbarObjetos
{
    static void Main(string[] args)
    {

        /*
        Producto testProducto = new Producto();

        Producto producto1 = new Producto(1, "pañales", 3.43, 4.12, "Limpieza");

        if (producto1.hayPrecioVenta())
        {
            Console.WriteLine("El producto está a la venta");
        }
        else
        {
            Console.WriteLine("El producto no fue publicado aún");
        }


        */

        Producto producto1 = new Producto(1, "Mouse", 10.3, 15.2, "Tec");
        Console.WriteLine(
            "codigo: " + producto1.codigo + " " +
            "Descripcion: " + producto1.description + " " +
            "precio de compra: " + producto1.precioDeCompra + " " +
            "precio de venta: " + producto1.precioDeVenta + " " +
            "Categoria: " + producto1.categoria);

        producto1.codigo = 02;
        producto1.description = "Teclado";
        producto1.precioDeCompra = 41.2;
        producto1.precioDeVenta = 62;
        producto1.categoria = "IT";



    }
}



