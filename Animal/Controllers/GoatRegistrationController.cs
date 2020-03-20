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
    public class GoatRegistrationController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public GoatRegistrationController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            IEnumerable<GoatRegistration> Goats = _repo.GoatRegistration.GetModel().AsEnumerable();
            IEnumerable<GoatBreed> GoatBreed = _repo.GoatBreed.GetModel().AsEnumerable();
            IEnumerable<GoatIndexVM> Goatss = (from g in Goats
                                               from b in GoatBreed
                                               where g.GoatBreedId == b.Id
                                               select new GoatIndexVM
                                               {
                                                   Goat = g,
                                                   Breed = b
                                               });

            return View(Goatss);
        }
        public IActionResult Selection()
        {
            GoatSelectionVM GoatSelection = new GoatSelectionVM();
            GoatSelection.GoatBreeds = new SelectList(_repo.GoatBreed.GetModel(), "BreedName", "BreedName");
            IEnumerable<GoatRegistration> Goats = _repo.GoatRegistration.GetModel().AsEnumerable();
            IEnumerable<GoatBreed> GoatBreed = _repo.GoatBreed.GetModel().AsEnumerable();
            IEnumerable<GoatIndexVM> Goatss = (from g in Goats
                                               from b in GoatBreed
                                               where g.GoatBreedId == b.Id
                                               select new GoatIndexVM
                                               {
                                                   Goat = g,
                                                   Breed = b
                                               });

            GoatSelection.GoatIndex = Goatss;

            return View(GoatSelection);
        }
        [HttpPost]
        public IActionResult Selection(GoatSelectionVM selectionVM)
        {
            GoatSelectionVM GoatSelection = new GoatSelectionVM();
            GoatSelection = selectionVM;
            GoatSelection.GoatBreeds = new SelectList(_repo.GoatBreed.GetModel(), "BreedName", "BreedName");
            IEnumerable<GoatRegistration> Goats = _repo.GoatRegistration.GetModel().AsEnumerable();
            IEnumerable<GoatBreed> GoatBreed = _repo.GoatBreed.GetModel().AsEnumerable();
            IEnumerable<GoatIndexVM> Goatss = (from g in Goats
                                               from b in GoatBreed
                                               where g.GoatBreedId == b.Id
                                               select new GoatIndexVM
                                               {
                                                   Goat = g,
                                                   Breed = b
                                               });
            GoatSelection.GoatIndex = Goatss;

            if (!string.IsNullOrEmpty(selectionVM.MainPurpose))
            {
                GoatSelection.GoatIndex = GoatSelection.GoatIndex.Where(m => m.Goat.MainPurpose == selectionVM.MainPurpose);
            }
            if (!string.IsNullOrEmpty(selectionVM.Weather))
            {
                GoatSelection.GoatIndex = GoatSelection.GoatIndex.Where(m => m.Goat.Weather == selectionVM.Weather);
            }
            if (!string.IsNullOrEmpty(selectionVM.Availability))
            {
                GoatSelection.GoatIndex = GoatSelection.GoatIndex.Where(m => m.Goat.Availability == selectionVM.Availability);
            }
            if (!string.IsNullOrEmpty(selectionVM.GoatBreed))
            {
                GoatSelection.GoatIndex = GoatSelection.GoatIndex.Where(m => m.Breed.BreedName == selectionVM.GoatBreed);
            }
            return View(GoatSelection);
        }


        public IActionResult Details(int id)
        {
            GoatRegistration feed = _repo.GoatRegistration.GetById(id);

            return View(feed);
        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            GoatCreateVM model = new GoatCreateVM();

            if (id.HasValue)
            {
                GoatRegistration feed = _repo.GoatRegistration.GetById(id.Value);


                if (feed != null)
                {
                    model = _mapper.Map<GoatRegistration, GoatCreateVM>(feed);

                }
            }
            //model.speciess = (_repo.Species.GetModel(), "id", "speciesName");
            //model.breeds = new SelectList(_repo.Breed.GetModel(), "id", "breedNameShort");
            //model.owners = new SelectList(_repo.OwnerKeeper.GetModel(), "id", "fullName");
            //model.farms = new SelectList(_repo.Farm.GetModel(), "id", "orgtanizationName");
            //model.keepers = new SelectList(_repo.keepers.GetModel(), "id", "fullName");
            //model.dams = new SelectList(_repo.AnimalRegistration.GetModel().Where(m=>m.gender=="Male"), "id", "earTagNo");
            //model.sires = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender == "Female"), "id", "earTagNo");
            model.id = 0;

            model.GoatBreeds = new SelectList(_repo.GoatBreed.GetModel(), "Id", "BreedName");
            model.UpdatedAt = DateTime.Now.Date;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, GoatCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                        model.UpdatedAt = DateTime.Now;
                        GoatRegistration animal = _mapper.Map<GoatCreateVM, GoatRegistration>(model);
                        animal.GoatBreedId = model.GoatBreedId;
                        model.GoatBreeds = new SelectList(_repo.GoatBreed.GetModel(), "Id", "BreedName", animal.GoatBreedId);
                        animal.UpdatedBy = "admin";
                        
                        _repo.GoatRegistration.Insert(animal);
                        _repo.Save();
                        //var path = _host.WebRootPath + "\\images\\animal\\";

                        //if (!Directory.Exists(path))
                        //{
                        //    Directory.CreateDirectory(path);
                        //}
                        //if (file != null)
                        //{

                        //    var fileName = Path.Combine(path, animal.earTagNo + ".jpg");
                        //    file.CopyTo(new FileStream(fileName, FileMode.Create));
                        //}
                    }
                    else
                    {
                        //var config = new MapperConfiguration(cfg =>
                        //{
                        //    cfg.CreateMap<AnimalVM, AnimalRegistration>();
                        //});

                        //IMapper iMapper = config.CreateMapper();

                        GoatRegistration animal = _mapper.Map<GoatCreateVM, GoatRegistration>(model);
                        animal.GoatBreedId = model.GoatBreedId;
                        animal.UpdatedBy = "admin";
                        animal.UpdatedAt = DateTime.Now;
                        _repo.GoatRegistration.Update(animal);
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
                    model.GoatBreeds = new SelectList(_repo.GoatBreed.GetModel(), "Id", "BreedName");
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
            GoatRegistration feed = _repo.GoatRegistration.GetById(id);
            _repo.GoatRegistration.Delete(id);

            return RedirectToAction("Index");

        }
    }
}