using AffinityChart.Data;
using AffinityChart.Models;
using AffinityChart.Services;
using Microsoft.AspNetCore.Mvc;

namespace AffinityChart.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AffinityController : ControllerBase
{
    private readonly AffinityContext _context;
    public AffinityController(AffinityContext context)
    {
        _context = context;
    }
    // GET all action
    [HttpGet]
    public ActionResult<List<Affinity>> GetAll() =>
        _context.affinityChart.ToList();

    //Get by ID action

    [HttpGet("{id}")]
    public ActionResult<Affinity> Get(int id)
    {
        var affinity = AffinityService.Get(id);

        if (affinity == null)
            return NotFound();
        
        return affinity;
    }

    //Post action
    [HttpPost]
    public IActionResult Create(Affinity affinity)
    {
        AffinityService.Add(affinity);
        return CreatedAtAction(nameof(Get), new { id = affinity.affinity_id}, affinity);
    }

    // Put action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Affinity affinity)
    {
        if (id != affinity.affinity_id)
            return BadRequest();
        
        var existingaffinity = AffinityService.Get(id);
        if (existingaffinity is null)
            return NotFound();

        AffinityService.Update(affinity);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var affinity = AffinityService.Get(id);

        if (affinity is null)
            return NotFound();
        
        AffinityService.Delete(id);

        return NoContent();
    }
}