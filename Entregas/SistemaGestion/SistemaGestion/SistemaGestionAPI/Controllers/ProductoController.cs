using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> TraerProductos()
        {
            var productos = ProductoBussiness.ObtenerProductos();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> TraerProducto(int id)
        {
            var producto = ProductoBussiness.ObtenerProductoPorId(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public ActionResult<Producto> CrearProducto(Producto producto)
        {
            ProductoBussiness.AgregarProducto(producto);
            return CreatedAtAction(nameof(TraerProducto), new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public IActionResult ModificarProducto(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            ProductoBussiness.ModificarProducto(producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            ProductoBussiness.EliminarProducto(id);
            return NoContent();
        }
    }
}


