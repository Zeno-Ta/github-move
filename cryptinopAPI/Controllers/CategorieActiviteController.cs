using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cryptinopAPI.DAL.Context;
using cryptinopAPI.Models;
using AutoMapper;
using cryptinop_cpo.Models;

namespace cryptinopAPI.Controllers
{
    [Route("api/CategorieActivite")]
    [ApiController]
    public class CategorieActiviteController : ControllerBase
    {
        private IMapper _mapper;
        private readonly CryptinopContext _context;

        public CategorieActiviteController(CryptinopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/CategorieActivite
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorie>>> GetCategories()
        {
            IEnumerable<CategorieActivite> categories= await _context.Categories.ToListAsync();

            var response =_mapper.Map<List<Categorie>>(categories);

            return response;
        }

        // GET: api/CategorieActivite/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategorieActivite>> GetCategorieActivite(int id)
        {
            var categorieActivite = await _context.Categories.FindAsync(id);

            if (categorieActivite == null)
            {
                return NotFound();
            }

            return categorieActivite;
        }

        // PUT: api/CategorieActivite/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorieActivite(int id, CategorieActivite categorieActivite)
        {
            if (id != categorieActivite.Id)
            {
                return BadRequest();
            }

            _context.Entry(categorieActivite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieActiviteExists(id))
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

        // POST: api/CategorieActivite
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CategorieActivite>> PostCategorieActivite(CategorieActivite categorieActivite)
        {
            _context.Categories.Add(categorieActivite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategorieActivite", new { id = categorieActivite.Id }, categorieActivite);
        }

        // DELETE: api/CategorieActivite/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CategorieActivite>> DeleteCategorieActivite(int id)
        {
            var categorieActivite = await _context.Categories.FindAsync(id);
            if (categorieActivite == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(categorieActivite);
            await _context.SaveChangesAsync();

            return categorieActivite;
        }

        private bool CategorieActiviteExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
