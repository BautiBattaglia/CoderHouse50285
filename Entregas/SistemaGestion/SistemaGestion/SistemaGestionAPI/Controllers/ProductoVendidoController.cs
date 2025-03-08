using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Collections.Generic;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductoVendido>> TraerProductosVendidos()
        {
            var productosVendidos = ProductoVendidoBussiness.ObtenerProductosVendidos();
            return Ok(productosVendidos);
        }
    }
}
