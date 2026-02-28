using Microsoft.AspNetCore.Mvc;
using ApiSolid.Services;
using ApiSolid.Models;

namespace ApiSolid.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoService _service;

        public ProductosController(ProductoService service)
        {
            _service = service; 
        }

        [HttpGet]
        public IActionResult Get() =>
            Ok(_service.GetAll());

        [HttpPost]
        public IActionResult Post(Producto producto)
        {
            _service.Add(producto);
            return Created("", producto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok("Producto eliminado correctamente");
        }
    }
}