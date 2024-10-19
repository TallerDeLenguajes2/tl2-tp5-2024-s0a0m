using Microsoft.AspNetCore.Mvc;
using tl2_tp5_2024_s0a0m.Models;
using tl2_tp5_2024_s0a0m.Repositorios;

namespace tl2_tp5_2024_s0a0m.Controllers;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private readonly ILogger<PresupuestosController> _logger;
    private readonly IPresupuestosRepository presupuestoR;

    public PresupuestosController(ILogger<PresupuestosController> logger)
    {
        _logger = logger;
        presupuestoR= new PresupuestosRepository();
    }

    [HttpGet]
    public ActionResult<List<Presupuesto>> ObtenerPresupuestos()
    {
        return Ok(presupuestoR.ListarPresupuestos());
    }
}
