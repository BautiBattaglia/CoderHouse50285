using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> TraerUsuarios()
        {
            try
            {
                var usuarios = UsuarioBussiness.ObtenerUsuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> TraerUsuario(int id)
        {
            if (id <= 0)
            {
                return BadRequest("El 'id' debe ser un valor positivo.");
            }

            try
            {
                var usuario = UsuarioBussiness.ObtenerUsuarioPorId(id);
                if (usuario == null)
                {
                    return NotFound("Usuario no encontrado.");
                }

                return Ok(usuario);
            }
            catch (ArgumentException ex)
            {
                // Log.Error(ex, "Error al obtener usuario"); // Ejemplo de llamada a log
                return BadRequest($"Error en la solicitud: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Log.Error(ex, "Error desconocido"); // Ejemplo de llamada a log
                return StatusCode(500, "Ocurrió un error inesperado. Por favor, inténtalo de nuevo más tarde.");
            }
        }

        [HttpPost]
        public ActionResult<Usuario> CrearUsuario(Usuario usuario)
        {
            try
            {
                UsuarioBussiness.AgregarUsuario(usuario);
                return CreatedAtAction(nameof(TraerUsuario), new { id = usuario.Id }, usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult ModificarUsuario(int id, Usuario usuario)
        {
            try
            {
                if (id != usuario.Id)
                {
                    return BadRequest("ID mismatch");
                }

                UsuarioBussiness.ModificarUsuario(usuario);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarUsuario(int id)
        {
            try
            {
                UsuarioBussiness.EliminarUsuario(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
