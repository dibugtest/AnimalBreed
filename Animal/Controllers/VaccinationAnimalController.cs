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
    public class VaccinationAnimalController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public VaccinationAnimalController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            IEnumerable<VaccinationAnimal> vaccin = _repo.VaccinationAnimals.GetModel().AsEnumerable();
           
            return View(vaccin);
        }
      
        public IActionResult Details(int id)
        {
            GoatRegistration feed = _repo.GoatRegistration.GetById(id);

            return View(feed);
        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            VaccinAnimalCreateVM model = new VaccinAnimalCreateVM();

            if (id.HasValue)
            {
                VaccinationAnimal feed = _repo.VaccinationAnimals.GetById(id.Value);


                if (feed != null)
                {
                    model = _mapper.Map<VaccinationAnimal, VaccinAnimalCreateVM>(feed);

                }
            }
            model.id = 0;

            model.animalRegistrations = new SelectList(_repo.AnimalRegistration.GetModel(), "id", "earTagNo");
            model.Vaccinations = new SelectList(_repo.Vaccinations.GetModel(), "id", "vaccinName");
            model.Diseases = new SelectList(_repo.Diseases.GetModel(), "id", "diseasesNameEng");
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, VaccinAnimalCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                        //model.UpdatedAt = DateTime.Now;
                        VaccinationAnimal animal = _mapper.Map<VaccinAnimalCreateVM, VaccinationAnimal>(model);
                        animal.earTagNo = _repo.AnimalRegistration.GetById(model.animalId).earTagNo;
                        animal.vaccination = _repo.Vaccinations.GetById(model.vaccinId);
                        animal.animalRegistration = _repo.AnimalRegistration.GetById(model.animalId);
                        model.animalRegistrations = new SelectList(_repo.AnimalRegistration.GetModel(), "id", "earTagNo");
                        model.Vaccinations = new SelectList(_repo.Vaccinations.GetModel(), "id", "vaccinName");
                        model.Diseases = new SelectList(_repo.Diseases.GetModel(), "id", "diseasesNameEng");

                        
                        _repo.VaccinationAnimals.Insert(animal);
                        _repo.Save();
                       
                    }
                    else
                    {
                       
                        VaccinationAnimal animal = _mapper.Map<VaccinAnimalCreateVM, VaccinationAnimal>(model);
                        animal.vaccination = _repo.Vaccinations.GetById(model.vaccinId);
                        animal.animalRegistration = _repo.AnimalRegistration.GetById(model.animalId);
                        animal.earTagNo = _repo.AnimalRegistration.GetById(model.animalId).earTagNo;
                        _repo.VaccinationAnimals.Update(animal);
                    }
                }
                else
                {
                    //model.speciess = new SelectList(_repo.Species.GetModel(), "id", "speciesName",model.speciesId);
                    //model.breeds = new SelectList(_repo.Breed.GetModel(), "id", "breedNameShort",model.breedId);
                    //model.owners = new SelectList(_repo.OwnerKeeper.GetModel(), "id", "fullName",model.ownerId);
                    //model.keepers = new SelectList(_repo.keepers.GetModel(), "id", "fullName",model.keeperId);
                    //model.farms = new SelectList(_repo.Farm.GetModel(), "id", "orgtanizationName",model.farmId);
                    //model.dams = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender == "Male"), "id", "earTagNo",model.damId);
                    //model.sires = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender == "Female"), "id", "earTagNo",model.sireId);
                    //model.declaredDate = DateTime.Now.Date;
                    model.animalRegistrations = new SelectList(_repo.AnimalRegistration.GetModel(), "id", "earTagNo",model.animalId);
                    model.Vaccinations = new SelectList(_repo.Vaccinations.GetModel(), "id", "vaccinName",model.vaccinId);
                    model.Diseases = new SelectList(_repo.Diseases.GetModel(), "id", "diseasesNameEng",model.diseasesId);
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
            VaccinationAnimal feed = _repo.VaccinationAnimals.GetById(id);
            _repo.VaccinationAnimals.Delete(id);

            return RedirectToAction("Index");

        }
    }
}