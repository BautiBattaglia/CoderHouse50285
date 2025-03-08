//Codeando para probar que onda

//Supongamos que debemos hacer un control básico del stock de nuestrosproductos en un depósito.
//Nos brindan la cantidad de productos en depósito y la cantidad de productos vendidos. Entonces se debe actualizar el stock.
//Aquí utilizamos Console.Readline() para obtener la cantidad a vender y seguir trabajando con variables

int cantidadProductosVendidos;
int cantidadProductosDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos: ");

cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidadProductosDeposito - cantidadProductosVendidos;

// Estructura IF/ELSE
if (stock == 0)
{
    Console.WriteLine("Reponer stock de repuestos.");
    //Primera forma de sumar
    cantidadProductosDeposito += 10;
    //Segunda forma de sumar
    cantidadProductosDeposito = cantidadProductosDeposito + 10;
    Console.WriteLine("Stock renovado");

}
else
{
    if (stock <= 5)
    {
        Console.WriteLine("Stock mínimo, se debe reponer.");
        stock += 5;
        Console.WriteLine("Stock renovado.");
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    }
    else
    {
        Console.WriteLine("Informar a ventas {0} productos sin vender", stock);
    }
}




