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
    public class labsController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public labsController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/labs
        [HttpGet("[action]")]
        public IEnumerable<lab> Getlab()
        {
            return _context.labs.GetModel();
        }

        // GET: api/labs/5
        [HttpGet("{id}")]
        public IActionResult Getlab([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lab = _context.labs.GetById(id);

            if (lab == null)
            {
                return NotFound();
            }

            return Ok(lab);
        }

        // PUT: api/labs/5
        [HttpPut("{id}")]
        public IActionResult Putlab([FromRoute] int id, [FromBody] lab lab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lab.id)
            {
                return BadRequest();
            }

            lab.id = id;
            _context.labs.Update(lab);
            

           
                if (!labExists(id))
                {
                    return NotFound();
                }

            return NoContent();
        }

        // POST: api/labs
        [HttpPost]
        public IActionResult Postlab([FromBody] lab lab)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.labs.Insert(lab);

            return CreatedAtAction("Getlab", new { id = lab.id }, lab);
        }

        // DELETE: api/labs/5
        [HttpDelete("{id}")]
        public IActionResult Deletelab([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lab = _context.labs.GetById(id);
            if (lab == null)
            {
                return NotFound();
            }

            _context.labs.Delete(id);

            return Ok(lab);
        }

        private bool labExists(int id)
        {
            return _context.labs.GetModel().Any(e => e.id == id);
        }
    }
}