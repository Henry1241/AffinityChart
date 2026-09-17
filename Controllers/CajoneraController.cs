using AffinityChart.Models;
using AffinityChart.Services;
using Microsoft.AspNetCore.Mvc;

namespace AffinityChart.Controllers;

[ApiController]
[Route("[controller]")]
public class CajoneraController : ControllerBase
{
    public CajoneraController()
    {
        
    }
    // GET all action
    [HttpGet]
    public ActionResult<List<Cajonera>> GetAll() =>
        CajoService.GetAll();

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
        return CreatedAtAction(nameof(Get), new { id = cajonero.Cajon_id}, cajonero);
    }

    // Put action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Cajonera cajonero)
    {
        if (id != cajonero.Cajon_id)
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