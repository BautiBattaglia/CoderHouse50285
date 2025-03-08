using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class UsuarioData
    {
        private static string connectionString = "Server=AF01-BAUTISTA\\SQLEXPRESS;Database=CursoC#;Integrated Security=True;";

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id, Nombre, Apellido, Email, Password FROM Usuarios", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Email = reader.GetString(3),
                        Password = reader.GetString(4)
                    });
                }
            }
            return usuarios;
        }

        public static Usuario ObtenerUsuarioPorId(int id)
        {
            Usuario usuario = null;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id, Nombre, Apellido, Email, Password FROM Usuarios WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Email = reader.GetString(3),
                        Password = reader.GetString(4)
                    };
                }
            }
            return usuario;
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Usuarios (Nombre, Apellido, Email, Password) VALUES (@Nombre, @Apellido, @Email, @Password)", conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Password", usuario.Password);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarUsuario(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Password = @Password WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Password", usuario.Password);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
