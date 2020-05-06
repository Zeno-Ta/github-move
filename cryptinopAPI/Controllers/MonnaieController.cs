using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cryptinopAPI.DAL.Context;
using cryptinopAPI.Models;

namespace cryptinopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonnaieController : ControllerBase
    {
        private readonly CryptinopContext _context;

        public MonnaieController(CryptinopContext context)
        {
            _context = context;
        }

        // GET: api/Monnaie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Monnaie>>> GetMonnaies()
        {
            return await _context.Monnaies.ToListAsync();
        }

        // GET: api/Monnaie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Monnaie>> GetMonnaie(int id)
        {
            var monnaie = await _context.Monnaies.FindAsync(id);

            if (monnaie == null)
            {
                return NotFound();
            }

            return monnaie;
        }

        // PUT: api/Monnaie/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonnaie(int id, Monnaie monnaie)
        {
            if (id != monnaie.Id)
            {
                return BadRequest();
            }

            _context.Entry(monnaie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonnaieExists(id))
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

        // POST: api/Monnaie
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Monnaie>> PostMonnaie(Monnaie monnaie)
        {
            _context.Monnaies.Add(monnaie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonnaie", new { id = monnaie.Id }, monnaie);
        }

        // DELETE: api/Monnaie/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Monnaie>> DeleteMonnaie(int id)
        {
            var monnaie = await _context.Monnaies.FindAsync(id);
            if (monnaie == null)
            {
                return NotFound();
            }

            _context.Monnaies.Remove(monnaie);
            await _context.SaveChangesAsync();

            return monnaie;
        }

        private bool MonnaieExists(int id)
        {
            return _context.Monnaies.Any(e => e.Id == id);
        }
    }
}
