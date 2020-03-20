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
    public class GeneralNutrationsController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public GeneralNutrationsController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/GeneralNutrations
        [HttpGet("[action]")]
        public IEnumerable<GeneralNutration> GetGeneralNutrations()
        {
            return _context.GeneralNutrition.GetModel() ;
        }

        // GET: api/GeneralNutrations/5
        [HttpGet("[action]/{id}")]
        public IActionResult GetGeneralNutration([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var generalNutration =_context.GeneralNutrition.GetById(id);

            if (generalNutration == null)
            {
                return NotFound();
            }

            return Ok(generalNutration);
        }

        // PUT: api/GeneralNutrations/5
        [HttpPut("[action]/{id}")]
        public IActionResult PutGeneralNutration([FromRoute] int id, [FromBody] GeneralNutration generalNutration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != generalNutration.id)
            {
                return BadRequest();
            }

            generalNutration.id = id;
            _context.GeneralNutrition.Update(generalNutration);
            
            
                if (!GeneralNutrationExists(id))
                {
                    return NotFound();
                }

            return NoContent();
        }

        // POST: api/GeneralNutrations
        [HttpPost("[action]")]
        public IActionResult PostGeneralNutration([FromBody] GeneralNutration generalNutration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GeneralNutrition.Insert(generalNutration);

            return CreatedAtAction("GetGeneralNutration", new { id = generalNutration.id }, generalNutration);
        }

        // DELETE: api/GeneralNutrations/5
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteGeneralNutration([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var generalNutration = _context.GeneralNutrition.GetById(id);
            if (generalNutration == null)
            {
                return NotFound();
            }

            _context.GeneralNutrition.Delete(id);

            return Ok(generalNutration);
        }

        private bool GeneralNutrationExists(int id)
        {
            return _context.GeneralNutrition.GetModel().Any(e => e.id == id);
        }
    }
}