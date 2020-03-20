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
    [Route("api/[controller]")]
    [ApiController]
    public class KeeperController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public KeeperController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Keeper
        [HttpGet]
        public IEnumerable<keeper> GetKeeper()
        {
            return _context.keepers.GetModel();
        }

        // GET: api/Keeper/5
        [HttpGet("{id}")]
        public IActionResult Getkeeper([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var keeper = _context.keepers.GetById(id);

            if (keeper == null)
            {
                return NotFound();
            }

            return Ok(keeper);
        }

        // PUT: api/Keeper/5
        [HttpPut("{id}")]
        public IActionResult Putkeeper([FromRoute] int id, [FromBody] keeper keeper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != keeper.id)
            {
                return BadRequest();
            }

            keeper.id = id;
            _context.keepers.Update(keeper);
            

            
                if (!keeperExists(id))
                {
                    return NotFound();
                }

            return NoContent();
        }

        // POST: api/Keeper
        [HttpPost]
        public IActionResult Postkeeper([FromBody] keeper keeper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.keepers.Insert(keeper);

            return CreatedAtAction("Getkeeper", new { id = keeper.id }, keeper);
        }

        // DELETE: api/Keeper/5
        [HttpDelete("{id}")]
        public IActionResult Deletekeeper([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var keeper = _context.keepers.GetById(id);
            if (keeper == null)
            {
                return NotFound();
            }

            _context.keepers.Delete(id);


            return Ok(keeper);
        }

        private bool keeperExists(int id)
        {
            return _context.keepers.GetModel().Any(e => e.id == id);
        }
    }
}