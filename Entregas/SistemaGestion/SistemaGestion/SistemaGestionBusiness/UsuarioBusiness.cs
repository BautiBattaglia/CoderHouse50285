using SistemaGestionData;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ObtenerUsuarios()
        {
            return UsuarioData.ObtenerUsuarios();
        }

        public static Usuario ObtenerUsuarioPorId(int id)
        {
            return UsuarioData.ObtenerUsuarioPorId(id);
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            UsuarioData.AgregarUsuario(usuario);
        }

        public static void EliminarUsuario(int id)
        {
            UsuarioData.EliminarUsuario(id);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }
    }
}
