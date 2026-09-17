using AffinityChart.Data;
using AffinityChart.Models;
using AffinityChart.Services;
using Microsoft.AspNetCore.Mvc;

namespace AffinityChart.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CajoneraController : ControllerBase
{
    private readonly CajoneraContext _context;
    public CajoneraController(CajoneraContext context)
    {
        _context = context;
    }
    // GET all action
    [HttpGet]
    public ActionResult<List<Cajonera>> GetAll() =>
        _context.cajonera.ToList();

    //Get by ID action

    [HttpGet("{id}")]
    public ActionResult<Cajonera> Get(int id)
    {
        var cajonero = CajoService.Get(id);

        if (cajonero == null)
            return NotFound();
        
        return cajonero;
    }

    //Post action
    [HttpPost]
    public IActionResult Create(Cajonera cajonero)
    {
        CajoService.Add(cajonero);
        return CreatedAtAction(nameof(Get), new { id = cajonero.cajon_id}, cajonero);
    }

    // Put action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Cajonera cajonero)
    {
        if (id != cajonero.cajon_id)
            return BadRequest();
        
        var existingCajonero = CajoService.Get(id);
        if (existingCajonero is null)
            return NotFound();

        CajoService.Update(cajonero);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var cajonero = CajoService.Get(id);

        if (cajonero is null)
            return NotFound();
        
        CajoService.Delete(id);

        return NoContent();
    }
}