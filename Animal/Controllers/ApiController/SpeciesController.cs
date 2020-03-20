using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Animal.Models;
using Animal.Repository;

namespace Animal.Controllers.ApiController
{
    [Route("/api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public SpeciesController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Specie
        [HttpGet]
        public IEnumerable<Species> GetSpecies()
        {
            return _context.Species.GetModel();
        }

        // GET: api/Specie/5
        [HttpGet("{id}")]
        public IActionResult GetSpecies([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var species = _context.Species.GetById(id);

            if (species == null)
            {
                return NotFound();
            }

            return Ok(species);
        }

        // PUT: api/Specie/5
        [HttpPut("{id}")]
        public IActionResult PutSpecies([FromRoute] int id, [FromBody] Species species)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != species.id)
            {
                return BadRequest();
            }
            species.id = id;
            _context.Species.Update(species);
            if (!SpeciesExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Specie
        [HttpPost]
        public IActionResult PostSpecies([FromBody] Species species)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Species.Insert(species);
            

            return CreatedAtAction("GetSpecies", new { id = species.id }, species);
        }

        // DELETE: api/Specie/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSpecies([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var species = _context.Species.GetById(id);
            if (species == null)
            {
                return NotFound();
            }

            _context.Species.Delete(id);
            

            return Ok(species);
        }

        private bool SpeciesExists(int id)
        {
            return _context.Species.GetModel().Any(e => e.id == id);
        }
    }
}