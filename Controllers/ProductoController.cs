using Microsoft.AspNetCore.Mvc;
using tl2_tp5_2024_s0a0m.Models;
using tl2_tp5_2024_s0a0m.Repositorios;

namespace tl2_tp5_2024_s0a0m.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private readonly ILogger<ProductoController> _logger;
    private readonly IProductoRepository productoR;

    public ProductoController(ILogger<ProductoController> logger)
    {
        _logger = logger;
        productoR= new ProductoRepository();
    }

    [HttpGet]
    public ActionResult<List<Producto>> ObtenerProductos()
    {
        return Ok(productoR.ListarProductos());
    }

    [HttpPost] 
    public ActionResult CrearProducto([FromBody] Producto producto) {
        productoR.CrearProducto(producto);
        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult ModificarNombreProducto(int id, [FromBody] Producto producto) {
        productoR.ModificarProducto(id, producto);
        return Ok();
    }
}
