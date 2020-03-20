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
    public class MIlkBaseNutritionController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public MIlkBaseNutritionController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/MIlkBaseNutrition
        [HttpGet]
        public IEnumerable<MIlkBaseNutrition> GetMilkBaseNutritions()
        {
            return _context.MilkBase.GetModel();
        }

        // GET: api/MIlkBaseNutrition/5
        [HttpGet("{id}")]
        public IActionResult GetMIlkBaseNutrition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mIlkBaseNutrition = _context.MilkBase.GetById(id);

            if (mIlkBaseNutrition == null)
            {
                return NotFound();
            }

            return Ok(mIlkBaseNutrition);
        }

        // PUT: api/MIlkBaseNutrition/5
        [HttpPut("{id}")]
        public IActionResult PutMIlkBaseNutrition([FromRoute] int id, [FromBody] MIlkBaseNutrition mIlkBaseNutrition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mIlkBaseNutrition.id)
            {
                return BadRequest();
            }

            mIlkBaseNutrition.id = id;
            _context.MilkBase.Update(mIlkBaseNutrition);

            if (!MIlkBaseNutritionExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/MIlkBaseNutrition
        [HttpPost]
        public IActionResult PostMIlkBaseNutrition([FromBody] MIlkBaseNutrition mIlkBaseNutrition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MilkBase.Insert(mIlkBaseNutrition);

           

            return CreatedAtAction("GetMIlkBaseNutrition", new { id = mIlkBaseNutrition.id }, mIlkBaseNutrition);
        }

        // DELETE: api/MIlkBaseNutrition/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMIlkBaseNutrition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mIlkBaseNutrition = _context.MilkBase.GetById(id);
            if (mIlkBaseNutrition == null)
            {
                return NotFound();
            }

            _context.MilkBase.Delete(id);
            

            return Ok(mIlkBaseNutrition);
        }

        private bool MIlkBaseNutritionExists(int id)
        {
            return _context.MilkBase.GetModel().Any(e => e.id == id);
        }
    }
}