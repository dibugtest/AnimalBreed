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
    public class VaccinationController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public VaccinationController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            IEnumerable<Vaccination> vaccin = _repo.Vaccinations.GetModel().AsEnumerable();
           

            return View(vaccin);
        }
        

        public IActionResult Details(int id)
        {
            Vaccination feed = _repo.Vaccinations.GetById(id);

            return View(feed);
        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            VaccinationCreateVM model = new VaccinationCreateVM();

            if (id.HasValue)
            {
                Vaccination feed = _repo.Vaccinations.GetById(id.Value);


                if (feed != null)
                {
                    model = _mapper.Map<Vaccination, VaccinationCreateVM>(feed);

                }
            }
             model.id = 0;
            model.VaccinationSubTypes = new SelectList(_repo.VaccinationSubTypes.GetModel(), "id", "SubTypeName");
            model.VaccinationTypes = new SelectList(_repo.VaccinationTypes.GetModel(), "id", "vaccinationName");
           // model.UpdatedAt = DateTime.Now.Date;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, VaccinationCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                       // model.UpdatedAt = DateTime.Now;
                        Vaccination animal = _mapper.Map<VaccinationCreateVM, Vaccination>(model);
                        animal.vaccinationType = _repo.VaccinationTypes.GetById(model.vaccinTypeId);
                        //animal
                        //animal.GoatBreedId = model.GoatBreedId;
                         model.VaccinationSubTypes = new SelectList(_repo.VaccinationSubTypes.GetModel(), "id", "SubTypeName",model.vaccinationSubTypeId);
                         model.VaccinationTypes = new SelectList(_repo.VaccinationTypes.GetModel(), "id", "vaccinationName",model.vaccinTypeId);
          
                        _repo.Vaccinations.Insert(animal);
                        _repo.Save();
                        
                    }
                    else
                    {
                       
                        Vaccination animal = _mapper.Map<VaccinationCreateVM, Vaccination>(model);
                        animal.vaccinationType = _repo.VaccinationTypes.GetById(model.vaccinTypeId);
                        _repo.Vaccinations.Update(animal);
                    }
                }
                else
                {
                    model.VaccinationSubTypes = new SelectList(_repo.VaccinationSubTypes.GetModel(), "id", "SubTypeName", model.vaccinationSubTypeId);
                    model.VaccinationTypes = new SelectList(_repo.VaccinationTypes.GetModel(), "id", "vaccinationName", model.vaccinTypeId);
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
            Vaccination feed = _repo.Vaccinations.GetById(id);
            _repo.Vaccinations.Delete(id);

            return RedirectToAction("Index");

        }
    }
}