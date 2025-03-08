using System;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int VentaId { get; set; }
        public int Cantidad { get; set; }
    }
}
