using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class ProductoData
    {
        private static string connectionString = "Server=AF01-BAUTISTA\\SQLEXPRESS;Database=CursoC#;Integrated Security=True;";

        public static void DescontarStock(int productoId, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Stock = Stock - @Cantidad WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@Id", productoId);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, Precio, Stock FROM Producto", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1).Trim(), // Trim para eliminar los espacios en blanco
                        Precio = Convert.ToDecimal(reader.GetDouble(2)), // Convertir de double a decimal
                        Stock = reader.GetInt32(3)
                    });
                }
            }
            return productos;
        }

        public static Producto ObtenerProductoPorId(int id)
        {
            Producto producto = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, Precio, Stock FROM Producto WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto = new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1).Trim(), // Trim para eliminar los espacios en blanco
                        Precio = Convert.ToDecimal(reader.GetDouble(2)), // Convertir de double a decimal
                        Stock = reader.GetInt32(3)
                    };
                }
            }
            return producto;
        }

        public static void AgregarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Producto (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock)", conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarProducto(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Producto WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Producto SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@Id", producto.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
