using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class VentaData
    {
        private static string connectionString = "Server=AF01-BAUTISTA\\SQLEXPRESS;Database=CursoC#;Integrated Security=True;";

        public static List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id, UsuarioId, Fecha, MontoTotal FROM Ventas", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ventas.Add(new Venta
                    {
                        Id = reader.GetInt32(0),
                        UsuarioId = reader.GetInt32(1),
                        Fecha = reader.GetDateTime(2),
                        MontoTotal = reader.GetDecimal(3)
                    });
                }
            }
            return ventas;
        }

        public static Venta ObtenerVentaPorId(int id)
        {
            Venta venta = null;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id, UsuarioId, Fecha, MontoTotal FROM Ventas WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    venta = new Venta
                    {
                        Id = reader.GetInt32(0),
                        UsuarioId = reader.GetInt32(1),
                        Fecha = reader.GetDateTime(2),
                        MontoTotal = reader.GetDecimal(3)
                    };
                }
            }
            return venta;
        }

        public static void AgregarVenta(Venta venta)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Ventas (UsuarioId, Fecha, MontoTotal) VALUES (@UsuarioId, @Fecha, @MontoTotal)", conn);
                cmd.Parameters.AddWithValue("@UsuarioId", venta.UsuarioId);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
