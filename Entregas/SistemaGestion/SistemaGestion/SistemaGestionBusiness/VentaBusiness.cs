using SistemaGestionData;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> ObtenerVentas()
        {
            return VentaData.ObtenerVentas();
        }

        public static Venta ObtenerVentaPorId(int id)
        {
            return VentaData.ObtenerVentaPorId(id);
        }

        public static void AgregarVenta(Venta venta)
        {
            venta.Fecha = DateTime.Today;
            VentaData.AgregarVenta(venta);
        }
    }
}
