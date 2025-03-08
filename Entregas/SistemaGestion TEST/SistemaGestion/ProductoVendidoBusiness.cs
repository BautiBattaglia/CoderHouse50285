using System;
using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            return ProductoVendidoData.ObtenerProductosVendidos();
        }

        public static void AgregarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.AgregarProductoVendido(productoVendido);
        }

        public static void EliminarProductoVendido(int id)
        {
            ProductoVendidoData.EliminarProductoVendido(id);
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
    }
}

