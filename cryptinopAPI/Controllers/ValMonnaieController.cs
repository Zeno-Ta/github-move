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
    public class ValMonnaieController : ControllerBase
    {
        private readonly CryptinopContext _context;

        public ValMonnaieController(CryptinopContext context)
        {
            _context = context;
        }

        // GET: api/ValMonnaie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ValMonnaie>>> GetValMonnaies()
        {
            return await _context.ValMonnaies.ToListAsync();
        }

        // GET: api/ValMonnaie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ValMonnaie>> GetValMonnaie(int id)
        {
            var valMonnaie = await _context.ValMonnaies.FindAsync(id);

            if (valMonnaie == null)
            {
                return NotFound();
            }

            return valMonnaie;
        }

        // PUT: api/ValMonnaie/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutValMonnaie(int id, ValMonnaie valMonnaie)
        {
            if (id != valMonnaie.Id)
            {
                return BadRequest();
            }

            _context.Entry(valMonnaie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ValMonnaieExists(id))
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

        // POST: api/ValMonnaie
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ValMonnaie>> PostValMonnaie(ValMonnaie valMonnaie)
        {
            _context.ValMonnaies.Add(valMonnaie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetValMonnaie", new { id = valMonnaie.Id }, valMonnaie);
        }

        // DELETE: api/ValMonnaie/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ValMonnaie>> DeleteValMonnaie(int id)
        {
            var valMonnaie = await _context.ValMonnaies.FindAsync(id);
            if (valMonnaie == null)
            {
                return NotFound();
            }

            _context.ValMonnaies.Remove(valMonnaie);
            await _context.SaveChangesAsync();

            return valMonnaie;
        }

        private bool ValMonnaieExists(int id)
        {
            return _context.ValMonnaies.Any(e => e.Id == id);
        }
    }
}
