using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Venta>> TraerVentas()
        {
            var ventas = VentaBussiness.ObtenerVentas();
            return Ok(ventas);
        }

        [HttpGet("{id}")]
        public ActionResult<Venta> TraerVenta(int id)
        {
            var venta = VentaBussiness.ObtenerVentaPorId(id);
            if (venta == null)
            {
                return NotFound();
            }
            return Ok(venta);
        }

        [HttpPost]
        public ActionResult<Venta> CargarVenta(Venta venta)
        {
            try
            {
                VentaBussiness.AgregarVenta(venta);
                return CreatedAtAction(nameof(TraerVenta), new { id = venta.Id }, venta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
