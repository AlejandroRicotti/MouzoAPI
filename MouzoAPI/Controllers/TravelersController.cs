using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MouzoAPI.Models;

namespace MouzoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelersController : ControllerBase
    {
        private readonly MouzoAPIContext _context;

        public TravelersController(MouzoAPIContext context)
        {
            _context = context;
        }

        // GET: api/Travelers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Traveler>>> GetTraveler()
        {
            return await _context.Traveler.ToListAsync();
        }

        // GET: api/Travelers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Traveler>> GetTraveler(int id)
        {
            var traveler = await _context.Traveler.FindAsync(id);

            if (traveler == null)
            {
                return NotFound();
            }

            return traveler;
        }

        // PUT: api/Travelers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTraveler(int id, Traveler traveler)
        {
            if (id != traveler.TravelerID)
            {
                return BadRequest();
            }

            _context.Entry(traveler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelerExists(id))
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

        // POST: api/Travelers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Traveler>> PostTraveler(Traveler traveler)
        {
            _context.Traveler.Add(traveler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTraveler", new { id = traveler.TravelerID }, traveler);
        }

        // DELETE: api/Travelers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Traveler>> DeleteTraveler(int id)
        {
            var traveler = await _context.Traveler.FindAsync(id);
            if (traveler == null)
            {
                return NotFound();
            }

            _context.Traveler.Remove(traveler);
            await _context.SaveChangesAsync();

            return traveler;
        }

        private bool TravelerExists(int id)
        {
            return _context.Traveler.Any(e => e.TravelerID == id);
        }
    }
}
