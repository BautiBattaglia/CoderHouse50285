using System;
using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> ObtenerVentas()
        {
            return VentaData.ObtenerVentas();
        }

        public static void AgregarVenta(Venta venta)
        {
            VentaData.AgregarVenta(venta);
        }

        public static void EliminarVenta(int id)
        {
            VentaData.EliminarVenta(id);
        }

        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }
    }
}

