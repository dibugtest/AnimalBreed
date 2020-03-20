using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Animal.Models;
using Animal.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Animal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public HomeController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            int animals = _repo.AnimalRegistration.GetModel().Count();
            int farms = _repo.Farm.GetModel().Count();
            int breeds = _repo.Breed.GetModel().Count();
            ViewBag.animals = animals.ToString();
            ViewBag.farms = farms.ToString();
            ViewBag.breeds = breeds.ToString();
            ViewBag.earTag = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender == "Female"), "earTagNo", "earTagNo");
            return View();
        }

        [HttpPost]
        public JsonResult getMilkRecord(string id)
        {
            var MilkRecord=_repo.MilkRecord.GetModel();
            var Milk = from p in MilkRecord
                                  where p.earTagNumber == id
                                  orderby p.recordingDate
                                  select new ChartData

                                  {
                                      Label = p.recordingDate.ToShortDateString(),
                                      Value = decimal.Parse(p.milkVolume)
                                  };


            return Json(Milk);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }
        [Route("/home/errorhandling/{statusCode}")]
        public IActionResult ErrorHandling(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the page could not be found";
                    break;

            }


            return View("NotFound");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
