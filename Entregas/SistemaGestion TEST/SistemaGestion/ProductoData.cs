using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Se necesita para SqlConnection, SqlCommand y SqlDataReader
using SistemaGestionEntities;


namespace SistemaGestionData

{
    public static class ProductoData
    {
        // Aquí se declara la cadena de conexión como una constante o propiedad estática
        private static string connectionString = "Server=tu_servidor;Database=tu_base_de_datos;User Id=tu_usuario;Password=tu_contraseña;";


        // Métodos
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, Precio FROM Productos", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = reader.GetDecimal(2)
                        });
                    }
                }
            }
            return productos;
        }


        public static void AgregarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)", conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.ExecuteNonQuery();
            }
        }


        public static void EliminarProducto(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
