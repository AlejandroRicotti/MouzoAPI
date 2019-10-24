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
    public class TravelsController : ControllerBase
    {
        private readonly MouzoAPIContext _context;

        public TravelsController(MouzoAPIContext context)
        {
            _context = context;
        }

        // GET: api/Travels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Travel>>> GetTravel()
        {
            return await _context.Travel.ToListAsync();
        }

        // GET: api/Travels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Travel>> GetTravel(int id)
        {
            var travel = await _context.Travel.FindAsync(id);

            if (travel == null)
            {
                return NotFound();
            }

            return travel;
        }

        // PUT: api/Travels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravel(int id, Travel travel)
        {
            if (id != travel.TravelID)
            {
                return BadRequest();
            }

            _context.Entry(travel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelExists(id))
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

        // POST: api/Travels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Travel>> PostTravel(Travel travel)
        {
            _context.Travel.Add(travel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravel", new { id = travel.TravelID }, travel);
        }

        // DELETE: api/Travels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Travel>> DeleteTravel(int id)
        {
            var travel = await _context.Travel.FindAsync(id);
            if (travel == null)
            {
                return NotFound();
            }

            _context.Travel.Remove(travel);
            await _context.SaveChangesAsync();

            return travel;
        }

        private bool TravelExists(int id)
        {
            return _context.Travel.Any(e => e.TravelID == id);
        }
    }
}
