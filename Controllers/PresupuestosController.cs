using Microsoft.AspNetCore.Mvc;
using tl2_tp5_2024_s0a0m.Models;
using tl2_tp5_2024_s0a0m.Repositorios;

namespace tl2_tp5_2024_s0a0m.Controllers;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private readonly ILogger<PresupuestosController> _logger;
    private readonly IProductoRepository productoR;

    public PresupuestosController(ILogger<PresupuestosController> logger)
    {
        _logger = logger;
        productoR= new ProductoRepository();
    }

    [HttpGet]
    public ActionResult<List<Presupuesto>> ObtenerPresupuestos()
    {
        return Ok(productoR.ListarProductos());
    }
}
