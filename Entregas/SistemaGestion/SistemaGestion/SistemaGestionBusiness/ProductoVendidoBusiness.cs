using SistemaGestionData;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            return ProductoVendidoData.ObtenerProductosVendidos();
        }

        public static ProductoVendido ObtenerProductoVendidoPorId(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendidoPorId(id);
        }

        public static void AgregarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.AgregarProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }

        public static void EliminarProductoVendido(int id)
        {
            ProductoVendidoData.EliminarProductoVendido(id);
        }
    }
}
