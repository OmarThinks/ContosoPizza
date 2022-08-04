using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza;

[Route("api/[controller]")]
[ApiController]
public class MyC : ControllerBase
{
    private readonly ContosoPizzaContext _context;

    public MyC(ContosoPizzaContext context)
    {
        _context = context;
    }

    // GET: api/MyC
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pizza>>> GetPizza()
    {
      if (_context.Pizza == null)
      {
          return NotFound();
      }
        return await _context.Pizza.ToListAsync();
    }

    // GET: api/MyC/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Pizza>> GetPizza(int id)
    {
      if (_context.Pizza == null)
      {
          return NotFound();
      }
        var pizza = await _context.Pizza.FindAsync(id);

        if (pizza == null)
        {
            return NotFound();
        }

        return pizza;
    }

    // PUT: api/MyC/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPizza(int id, Pizza pizza)
    {
        if (id != pizza.Id)
        {
            return BadRequest();
        }

        _context.Entry(pizza).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PizzaExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/MyC
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Pizza>> PostPizza(Pizza pizza)
    {
      if (_context.Pizza == null)
      {
          return Problem("Entity set 'ContosoPizzaContext.Pizza'  is null.");
      }
        Pizza newPizza = new() { Name =pizza.Name, IsGlutenFree = pizza.IsGlutenFree};
        _context.Pizza.Add(newPizza);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPizza", new { id = pizza.Id }, pizza);
    }

    // DELETE: api/MyC/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePizza(int id)
    {
        if (_context.Pizza == null)
        {
            return NotFound();
        }
        var pizza = await _context.Pizza.FindAsync(id);
        if (pizza == null)
        {
            return NotFound();
        }

        _context.Pizza.Remove(pizza);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PizzaExists(int id)
    {
        return (_context.Pizza?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}
