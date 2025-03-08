using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class ProductoVendidoData
    {
        private static string connectionString = "Server=AF01-BAUTISTA\\SQLEXPRESS;Database=CursoC#;Integrated Security=True;";

        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductoVendido productoVendido = new ProductoVendido
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ProductoId = reader.GetInt32(reader.GetOrdinal("ProductoId")),
                            VentaId = reader.GetInt32(reader.GetOrdinal("VentaId")),
                            Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                        };
                        productosVendidos.Add(productoVendido);
                    }
                }
            }

            return productosVendidos;
        }

        public static ProductoVendido ObtenerProductoVendidoPorId(int id)
        {
            ProductoVendido productoVendido = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        productoVendido = new ProductoVendido
                        {
                            Id = (int)reader["Id"],
                            ProductoId = (int)reader["ProductoId"],
                            VentaId = (int)reader["VentaId"],
                            Cantidad = (int)reader["Cantidad"]
                        };
                    }
                }
            }

            return productoVendido;
        }




        public static void AgregarProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductoVendido (ProductoId, VentaId, Cantidad) VALUES (@ProductoId, @VentaId, @Cantidad)", conn);
                cmd.Parameters.AddWithValue("@ProductoId", productoVendido.ProductoId);
                cmd.Parameters.AddWithValue("@VentaId", productoVendido.VentaId);
                cmd.Parameters.AddWithValue("@Cantidad", productoVendido.Cantidad);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarProductoVendido(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductoVendido WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductoVendido SET ProductoId = @ProductoId, VentaId = @VentaId, Cantidad = @Cantidad WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@ProductoId", productoVendido.ProductoId);
                cmd.Parameters.AddWithValue("@VentaId", productoVendido.VentaId);
                cmd.Parameters.AddWithValue("@Cantidad", productoVendido.Cantidad);
                cmd.Parameters.AddWithValue("@Id", productoVendido.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
