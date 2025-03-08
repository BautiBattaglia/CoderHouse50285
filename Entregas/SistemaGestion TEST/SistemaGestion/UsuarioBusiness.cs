using System;
using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ObtenerUsuarios()
        {
            return UsuarioData.ObtenerUsuarios();
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
