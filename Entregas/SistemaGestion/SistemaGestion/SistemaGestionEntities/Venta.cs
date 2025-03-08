namespace SistemaGestionEntities
{
    public class Venta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; } 
    }
}
