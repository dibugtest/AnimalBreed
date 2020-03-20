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
    public class AiController : Controller
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public AiController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            IEnumerable<Ai> subtypes = _repo.Ais.GetModel().AsEnumerable();


            return View(subtypes);
        }


        public IActionResult Details(int id)
        {
            Ai feed = _repo.Ais.GetById(id);

            return View(feed);
        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            AiCreateVM model = new AiCreateVM();

            if (id.HasValue)
            {
                Ai feed = _repo.Ais.GetById(id.Value);


                if (feed != null)
                {
                    model = _mapper.Map<Ai, AiCreateVM>(feed);

                }
            }
            model.id = 0;
            model.previousInseminationDate = DateTime.Now;
            model.InseminationDate = DateTime.Now;
            model.Animals = new SelectList(_repo.AnimalRegistration.GetModel(), "id", "earTagNo");
            model.Bulls = new SelectList(_repo.AnimalRegistration.GetModel().Where(m=>m.gender.ToUpper()=="MALE"), "id", "earTagNo");
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, AiCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                        //model.UpdatedAt = DateTime.Now;
                        Ai animal = _mapper.Map<AiCreateVM, Ai>(model);
                        animal.earTagNo = _repo.AnimalRegistration.GetById(model.AnimalId).earTagNo;
                        animal.BullEarTag = _repo.AnimalRegistration.GetById(model.BullId).earTagNo;
                        model.Animals = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender.ToUpper() == "FEMALE"), "id", "earTagNo");
                        model.Bulls = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender.ToUpper() == "MALE"), "id", "earTagNo");

                        _repo.Ais.Insert(animal);
                        _repo.Save();

                    }
                    else
                    {

                        Ai animal = _mapper.Map<AiCreateVM, Ai>(model);

                        animal.earTagNo = _repo.AnimalRegistration.GetById(model.AnimalId).earTagNo;
                        animal.BullEarTag = _repo.AnimalRegistration.GetById(model.BullId).earTagNo;
                        _repo.Ais.Update(animal);
                    }
                }
                else
                {
                    model.Animals = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender.ToUpper() == "FEMALE"), "id", "earTagNo");
                    model.Bulls = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender.ToUpper() == "MALE"), "id", "earTagNo");
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
            Ai feed = _repo.Ais.GetById(id);
            _repo.Ais.Delete(id);

            return RedirectToAction("Index");

        }
    }
}