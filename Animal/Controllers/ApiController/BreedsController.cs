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
    public class BreedsController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public BreedsController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Breeds
        [HttpGet("getbreeds")]
        public IEnumerable<Breed> GetBreeds()
        {
            return _context.Breed.GetModel();
        }

        // GET: api/Breeds/5
        [HttpGet("getbreed/{id}")]
        public IActionResult GetBreed([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var breed = _context.Breed.GetById(id);

            if (breed == null)
            {
                return NotFound();
            }

            return Ok(breed);
        }

        // PUT: api/Breeds/5
        [HttpPut("putbreed/{id}")]
        public IActionResult PutBreed([FromRoute] int id, [FromBody] Breed breed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != breed.id)
            {
                return BadRequest();
            }
            breed.id = id;
            _context.Breed.Update(breed); 
            if (!BreedExists(id))
                {
                    return NotFound();
                }
            return NoContent();
        }

        // POST: api/Breeds
        [HttpPost("postbreed")]
        public IActionResult PostBreed([FromBody] Breed breed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Breed.Insert(breed);

            return CreatedAtAction("GetBreed", new { id = breed.id }, breed);
        }

        // DELETE: api/Breeds/5
        [HttpDelete("deleteBreed/{id}")]
        public IActionResult DeleteBreed([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var breed =_context.Breed.GetById(id);
            if (breed == null)
            {
                return NotFound();
            }

            _context.Breed.Delete(id);

            return Ok(breed);
        }

        private bool BreedExists(int id)
        {
            return _context.Breed.GetModel().Any(e => e.id == id);
        }
    }
}