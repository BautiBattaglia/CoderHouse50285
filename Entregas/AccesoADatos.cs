using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public static class DBConnection
{
    private static string connectionString = "Battaglia-db";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}

public static class UsuarioData
{
    public static Usuario ObtenerUsuario(int usuarioId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM Usuarios WHERE ID = @UsuarioId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            ID = (int)reader["ID"],
                            Nombre = reader["Nombre"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                }
            }
        }
        return null;
    }

    public static List<Usuario> ListarUsuarios()
    {
        var usuarios = new List<Usuario>();
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM Usuarios";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new Usuario
                        {
                            ID = (int)reader["ID"],
                            Nombre = reader["Nombre"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }
        }
        return usuarios;
    }

    public static void CrearUsuario(string nombre, string email)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "INSERT INTO Usuarios (Nombre, Email) VALUES (@Nombre, @Email)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void ModificarUsuario(int usuarioId, string nombre, string email)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "UPDATE Usuarios SET Nombre = @Nombre, Email = @Email WHERE ID = @UsuarioId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void EliminarUsuario(int usuarioId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "DELETE FROM Usuarios WHERE ID = @UsuarioId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                command.ExecuteNonQuery();
            }
        }
    }
}

public static class ProductoData
{
    public static Producto ObtenerProducto(int productoId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM Productos WHERE ID = @ProductoId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoId", productoId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Producto
                        {
                            ID = (int)reader["ID"],
                            Nombre = reader["Nombre"].ToString(),
                            Precio = (decimal)reader["Precio"]
                        };
                    }
                }
            }
        }
        return null;
    }

    public static List<Producto> ListarProductos()
    {
        var productos = new List<Producto>();
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM Productos";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            ID = (int)reader["ID"],
                            Nombre = reader["Nombre"].ToString(),
                            Precio = (decimal)reader["Precio"]
                        });
                    }
                }
            }
        }
        return productos;
    }

    public static void CrearProducto(string nombre, decimal precio)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Precio", precio);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void ModificarProducto(int productoId, string nombre, decimal precio)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio WHERE ID = @ProductoId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoId", productoId);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Precio", precio);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void EliminarProducto(int productoId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "DELETE FROM Productos WHERE ID = @ProductoId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoId", productoId);
                command.ExecuteNonQuery();
            }
        }
    }
}

public static class ProductoVendidoData
{
    public static ProductoVendido ObtenerProductoVendido(int productoVendidoId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM ProductosVendidos WHERE ID = @ProductoVendidoId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoVendidoId", productoVendidoId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ProductoVendido
                        {
                            ID = (int)reader["ID"],
                            ProductoID = (int)reader["ProductoID"],
                            VentaID = (int)reader["VentaID"],
                            Cantidad = (int)reader["Cantidad"]
                        };
                    }
                }
            }
        }
        return null;
    }

    public static List<ProductoVendido> ListarProductosVendidos()
    {
        var productosVendidos = new List<ProductoVendido>();
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM ProductosVendidos";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productosVendidos.Add(new ProductoVendido
                        {
                            ID = (int)reader["ID"],
                            ProductoID = (int)reader["ProductoID"],
                            VentaID = (int)reader["VentaID"],
                            Cantidad = (int)reader["Cantidad"]
                        });
                    }
                }
            }
        }
        return productosVendidos;
    }

    public static void CrearProductoVendido(int productoId, int ventaId, int cantidad)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "INSERT INTO ProductosVendidos (ProductoID, VentaID, Cantidad) VALUES (@ProductoID, @VentaID, @Cantidad)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoID", productoId);
                command.Parameters.AddWithValue("@VentaID", ventaId);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void ModificarProductoVendido(int productoVendidoId, int productoId, int ventaId, int cantidad)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "UPDATE ProductosVendidos SET ProductoID = @ProductoID, VentaID = @VentaID, Cantidad = @Cantidad WHERE ID = @ProductoVendidoId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoVendidoId", productoVendidoId);
                command.Parameters.AddWithValue("@ProductoID", productoId);
                command.Parameters.AddWithValue("@VentaID", ventaId);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void EliminarProductoVendido(int productoVendidoId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "DELETE FROM ProductosVendidos WHERE ID = @ProductoVendidoId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoVendidoId", productoVendidoId);
                command.ExecuteNonQuery();
            }
        }
    }
}

public static class VentaData
{
    public static Venta ObtenerVenta(int ventaId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM Ventas WHERE ID = @VentaId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VentaId", ventaId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Venta
                        {
                            ID = (int)reader["ID"],
                            UsuarioID = (int)reader["UsuarioID"],
                            Fecha = (DateTime)reader["Fecha"],
                            Total = (decimal)reader["Total"]
                        };
                    }
                }
            }
        }
        return null;
    }

    public static List<Venta> ListarVentas()
    {
        var ventas = new List<Venta>();
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "SELECT * FROM Ventas";
            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ventas.Add(new Venta
                        {
                            ID = (int)reader["ID"],
                            UsuarioID = (int)reader["UsuarioID"],
                            Fecha = (DateTime)reader["Fecha"],
                            Total = (decimal)reader["Total"]
                        });
                    }
                }
            }
        }
        return ventas;
    }

    public static void CrearVenta(int usuarioId, DateTime fecha, decimal total)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "INSERT INTO Ventas (UsuarioID, Fecha, Total) VALUES (@UsuarioID, @Fecha, @Total)";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UsuarioID", usuarioId);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@Total", total);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void ModificarVenta(int ventaId, int usuarioId, DateTime fecha, decimal total)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "UPDATE Ventas SET UsuarioID = @UsuarioID, Fecha = @Fecha, Total = @Total WHERE ID = @VentaId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VentaId", ventaId);
                command.Parameters.AddWithValue("@UsuarioID", usuarioId);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@Total", total);
                command.ExecuteNonQuery();
            }
        }
    }

    public static void EliminarVenta(int ventaId)
    {
        using (var connection = DBConnection.GetConnection())
        {
            connection.Open();
            var query = "DELETE FROM Ventas WHERE ID = @VentaId";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VentaId", ventaId);
                command.ExecuteNonQuery();
            }
        }
    }
}

public class Usuario
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
}

public class Producto
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}

public class ProductoVendido
{
    public int ID { get; set; }
    public int ProductoID { get; set; }
    public int VentaID { get; set; }
    public int Cantidad { get; set; }
}

public class Venta
{
    public int ID { get; set; }
    public int UsuarioID { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
}

