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
    public class FarmsController : ControllerBase
    {
        private readonly IUnitOfWork _repo;

        public FarmsController(IUnitOfWork repo)
        {
            _repo = repo;
        }

        // GET: api/Farms
        [HttpGet("getfarms")]
        public IEnumerable<Farm> GetFarms()
        {
            return _repo.Farm.GetModel();
        }

        // GET: api/Farms/5
        [HttpGet("getfarm/{id}")]
        public IActionResult GetFarm([FromQuery] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var farm = _repo.Farm.GetById(id);

            if (farm == null)
                return NotFound();

            return Ok(farm);
        }

        // PUT: api/Farms/5
        [HttpPut("putfarm/{id}")]
        public IActionResult PutFarm([FromRoute] int id, [FromBody] Farm farm)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != farm.id)
                return BadRequest();

            farm.id = id;
            _repo.Farm.Update(farm);
            
                if (!FarmExists(id))
                    return NotFound();

            return NoContent();
        }

        // POST: api/Farms
        [HttpPost("postfarm")]
        public IActionResult PostFarm([FromBody] Farm farm)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _repo.Farm.Insert(farm);

            return CreatedAtAction("GetFarm", new { id = farm.id }, farm);
        }

        // DELETE: api/Farms/5
        [HttpDelete("deletefarm/{id}")]
        public IActionResult DeleteFarm([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var farm = _repo.Farm.GetById(id);
            if (farm == null)
            {
                return NotFound();
            }

            _repo.Farm.Delete(id);

            return Ok(farm);
        }

        private bool FarmExists(int id)
        {
            return _repo.Farm.GetModel().Any(m=>m.id==id);
        }
    }
}