using System;
using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> ObtenerProductos()
        {
            return ProductoData.ObtenerProductos();
        }

        public static void AgregarProducto(Producto producto)
        {
            ProductoData.AgregarProducto(producto);
        }

        public static void EliminarProducto(int id)
        {
            ProductoData.EliminarProducto(id);
        }

        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }
    }
}

