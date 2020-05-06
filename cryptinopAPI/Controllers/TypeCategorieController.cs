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
    public class TypeCategorieController : ControllerBase
    {
        private readonly CryptinopContext _context;

        public TypeCategorieController(CryptinopContext context)
        {
            _context = context;
        }

        // GET: api/TypeCategorie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeCategorie>>> GetTypes()
        {
            return await _context.Types.ToListAsync();
        }

        // GET: api/TypeCategorie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeCategorie>> GetTypeCategorie(int id)
        {
            var typeCategorie = await _context.Types.FindAsync(id);

            if (typeCategorie == null)
            {
                return NotFound();
            }

            return typeCategorie;
        }

        // PUT: api/TypeCategorie/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeCategorie(int id, TypeCategorie typeCategorie)
        {
            if (id != typeCategorie.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeCategorie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeCategorieExists(id))
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

        // POST: api/TypeCategorie
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TypeCategorie>> PostTypeCategorie(TypeCategorie typeCategorie)
        {
            _context.Types.Add(typeCategorie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeCategorie", new { id = typeCategorie.Id }, typeCategorie);
        }

        // DELETE: api/TypeCategorie/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TypeCategorie>> DeleteTypeCategorie(int id)
        {
            var typeCategorie = await _context.Types.FindAsync(id);
            if (typeCategorie == null)
            {
                return NotFound();
            }

            _context.Types.Remove(typeCategorie);
            await _context.SaveChangesAsync();

            return typeCategorie;
        }

        private bool TypeCategorieExists(int id)
        {
            return _context.Types.Any(e => e.Id == id);
        }
    }
}
