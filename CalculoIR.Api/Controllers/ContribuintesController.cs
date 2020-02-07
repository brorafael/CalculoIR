using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CalculoIR.Model.DataContext;
using CalculoIR.Model.Entities;

namespace CalculoIR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuintesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contribuinte>>> GetContribuintes([FromServices] DataContext context) => await context.Contribuintes.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Contribuinte>> GetContribuinte(int id, [FromServices] DataContext context)
        {
            var contribuinte = await context.Contribuintes.FindAsync(id);

            if (contribuinte == null)
                return NotFound();

            return contribuinte;
        }

        [HttpPost]
        public async Task<ActionResult<Contribuinte>> PostContribuinte(Contribuinte contribuinte, [FromServices] DataContext context)
        {
            context.Contribuintes.Add(contribuinte);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetContribuinte", new { id = contribuinte.Id }, contribuinte);
        }
    }
}
