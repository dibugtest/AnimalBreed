using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Dtos;
using Animal.Models;
using Animal.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Animal.Controllers.ApiController
{
    [Route("/api/[controller]")]
    [ApiController]
    public class EarTagController : ControllerBase
    {
        private readonly IUnitOfWork _repo;

        public EarTagController(IUnitOfWork repo)
        {
            _repo = repo;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            IEnumerable<EarTag> all = _repo.EarTag.GetModel();
            return Ok(all);
        }
        [HttpGet("getlast")]
        public IActionResult GetLastEarTag()
        {
            EarTag ear = _repo.EarTag.GetModel().LastOrDefault();
            string earTag = "";
            if (ear == null)
                return NotFound();
            else
            {
                //earTag = ear == null ? "0" : (ear.earTagNo / 10).ToString();
                earTag = ear.earTagNo.ToString();
                return NotFound(earTag);
               // return Ok(earTag);
            }
        }
        [HttpPost("generateTag")]
        public IActionResult GenerateEarTag([FromBody]EarTagForCreation earTag)
        {
            if (earTag.start > earTag.end)
                return BadRequest("Start Number must be Less than End Number.");
            
            List<EarTag> listEar = new List<EarTag>();
            long startNum = earTag.start;
            long endNum =earTag.end;

            List<EarTag> EarTags = new List<EarTag>();
            string startStr = earTag.start.ToString().PadLeft(12, '0');
            string endStr = earTag.end.ToString().PadLeft(12, '0');
            //Loop from start Num to End Num
            for (int i = earTag.start; i <=earTag.end; i++)
            {
                //Reverse the Num
                int Num = i;
                //string Reverse = "0";
                string numString = i.ToString();
                char[] charArray = numString.ToCharArray();
                Array.Reverse(charArray);
                string revString = new string(charArray);
                // If you need the numeric value too:
                int revNumber = Convert.ToInt32(revString);
                int sum = 0;
                int j = 1;
                int checkBit = 0;

                //Calculation of checkout
                foreach (char item in revString)
                {
                    sum = sum + Convert.ToInt32(item.ToString()) * j;
                    j++;
                }
                checkBit = sum % 9;
                //Append Checkbit

                string newNum = Num.ToString().Insert(Num.ToString().Length, checkBit.ToString());
                
                //Add Items to List
                EarTag ear = new EarTag();
                ear.earTagNo = Convert.ToInt32(newNum);
                ear.earTagNoStr = ear.earTagNo.ToString();

                listEar.Add(ear);
                
            }

            string EarTagsExists = "";
            for (int i = 0; i < listEar.Count; i++)
            {
                EarTag ear = _repo.EarTag.GetByTag(listEar[i].earTagNoStr);
                if (ear == null)
                {
                    _repo.EarTag.Insert(listEar[i]);
                }
                else
                {
                    EarTagsExists = listEar[i].earTagNoStr + ",";
                }


            }

            string errorMessage = "";
            if (EarTagsExists != "")
                errorMessage = EarTagsExists + " already exists.";
            
              // ModelState.AddModelError(string.Empty, EarTagsExists + " already exists. Remaining exists.");
           

            return Ok("Ear Tag Generated Successfully. "+ errorMessage);
        }
        
    }
}
