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
    public class PregnancyBaseNutritionController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public PregnancyBaseNutritionController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/PregnancyBaseNutrition
        [HttpGet]
        public IEnumerable<PregnancyBaseNutrition> GetPregnancyBaseNutritions()
        {
            return _context.PregnancyBaseNutrition.GetModel();
        }

        // GET: api/PregnancyBaseNutrition/5
        [HttpGet("{id}")]
        public IActionResult GetPregnancyBaseNutrition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pregnancyBaseNutrition =_context.PregnancyBaseNutrition.GetById(id);

            if (pregnancyBaseNutrition == null)
            {
                return NotFound();
            }

            return Ok(pregnancyBaseNutrition);
        }

        // PUT: api/PregnancyBaseNutrition/5
        [HttpPut("{id}")]
        public IActionResult PutPregnancyBaseNutrition([FromRoute] int id, [FromBody] PregnancyBaseNutrition pregnancyBaseNutrition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pregnancyBaseNutrition.id)
            {
                return BadRequest();
            }

            pregnancyBaseNutrition.id = id;
            _context.PregnancyBaseNutrition.Update(pregnancyBaseNutrition);

            if (!PregnancyBaseNutritionExists(id))
                {
                    return NotFound();
                }
               
            return NoContent();
        }

        // POST: api/PregnancyBaseNutrition
        [HttpPost]
        public IActionResult PostPregnancyBaseNutrition([FromBody] PregnancyBaseNutrition pregnancyBaseNutrition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PregnancyBaseNutrition.Insert(pregnancyBaseNutrition);
            

            return CreatedAtAction("GetPregnancyBaseNutrition", new { id = pregnancyBaseNutrition.id }, pregnancyBaseNutrition);
        }

        // DELETE: api/PregnancyBaseNutrition/5
        [HttpDelete("{id}")]
        public IActionResult DeletePregnancyBaseNutrition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pregnancyBaseNutrition = _context.PregnancyBaseNutrition.GetById(id);
            if (pregnancyBaseNutrition == null)
            {
                return NotFound();
            }

            _context.PregnancyBaseNutrition.Delete(id);
            

            return Ok(pregnancyBaseNutrition);
        }

        private bool PregnancyBaseNutritionExists(int id)
        {
            return _context.PregnancyBaseNutrition.GetModel().Any(e => e.id == id);
        }
    }
}