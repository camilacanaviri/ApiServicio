using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiServicio.Modelos.Dato;

namespace ApiServicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichajeCitumsController : ControllerBase
    {
        private readonly EmpresaVelmotorContext _context;

        public FichajeCitumsController(EmpresaVelmotorContext context)
        {
            _context = context;
        }

        // GET: api/FichajeCitums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FichajeCitum>>> GetFichajeCita()
        {
            return await _context.FichajeCita.ToListAsync();
        }

        // GET: api/FichajeCitums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FichajeCitum>> GetFichajeCitum(decimal id)
        {
            var fichajeCitum = await _context.FichajeCita.FindAsync(id);

            if (fichajeCitum == null)
            {
                return NotFound();
            }

            return fichajeCitum;
        }

        // PUT: api/FichajeCitums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFichajeCitum(decimal id, FichajeCitum fichajeCitum)
        {
            if (id != fichajeCitum.IdFichaje)
            {
                return BadRequest();
            }

            _context.Entry(fichajeCitum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FichajeCitumExists(id))
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

        // POST: api/FichajeCitums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FichajeCitum>> PostFichajeCitum(FichajeCitum fichajeCitum)
        {
            _context.FichajeCita.Add(fichajeCitum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFichajeCitum", new { id = fichajeCitum.IdFichaje }, fichajeCitum);
        }

        // DELETE: api/FichajeCitums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFichajeCitum(decimal id)
        {
            var fichajeCitum = await _context.FichajeCita.FindAsync(id);
            if (fichajeCitum == null)
            {
                return NotFound();
            }

            _context.FichajeCita.Remove(fichajeCitum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FichajeCitumExists(decimal id)
        {
            return _context.FichajeCita.Any(e => e.IdFichaje == id);
        }
    }
}
