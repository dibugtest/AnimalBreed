using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Models;
using Animal.Repository;
using Microsoft.AspNetCore.Mvc;
using Animal.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;

namespace Animal.Controllers
{
    public class VaccinationSubTypeController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public VaccinationSubTypeController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            IEnumerable<VaccinationSubType> subtypes = _repo.VaccinationSubTypes.GetModel().AsEnumerable();
          

            return View(subtypes);
        }
       
       
        public IActionResult Details(int id)
        {
            VaccinationSubType feed = _repo.VaccinationSubTypes.GetById(id);

            return View(feed);
        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            VaccinationSubTypeVM model = new VaccinationSubTypeVM();

            if (id.HasValue)
            {
                VaccinationSubType feed = _repo.VaccinationSubTypes.GetById(id.Value);


                if (feed != null)
                {
                    model = _mapper.Map<VaccinationSubType, VaccinationSubTypeVM>(feed);

                }
            }
             model.id = 0;
            model.VaccinationTypes = new SelectList(_repo.VaccinationTypes.GetModel(), "id", "vaccinationName");
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, VaccinationSubTypeVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                        //model.UpdatedAt = DateTime.Now;
                        VaccinationSubType animal = _mapper.Map<VaccinationSubTypeVM, VaccinationSubType>(model);
                       // animal.VaccinationTypeId = model.;
                        model.VaccinationTypes = new SelectList(_repo.VaccinationTypes.GetModel(), "id", "vaccinationName", animal.VaccinationTypeId);
                       // animal.UpdatedBy = "admin";
                        
                        _repo.VaccinationSubTypes.Insert(animal);
                        _repo.Save();
                       
                    }
                    else
                    {
                       
                        VaccinationSubType animal = _mapper.Map<VaccinationSubTypeVM, VaccinationSubType>(model);
                       
                        _repo.VaccinationSubTypes.Update(animal);
                    }
                }
                else
                {
                    model.VaccinationTypes = new SelectList(_repo.VaccinationTypes.GetModel(), "id", "vaccinationName");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }





        [HttpGet]
        public IActionResult DeleteAnimal(int id)
        {
            VaccinationSubType feed = _repo.VaccinationSubTypes.GetById(id);
            _repo.VaccinationSubTypes.Delete(id);

            return RedirectToAction("Index");

        }
    }
}