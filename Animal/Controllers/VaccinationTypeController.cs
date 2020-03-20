using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Models;
using Animal.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Animal.Controllers
{
   // [Authorize]
    public class VaccinationTypeController : Controller
    {
        private readonly IUnitOfWork _repo;

        public VaccinationTypeController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            IEnumerable<VaccinationType> all = _repo.VaccinationTypes.GetModel();
            return View(all);
        }

        public IActionResult Details(int id)
        {
            VaccinationType feed = _repo.VaccinationTypes.GetById(id);
            return View(feed);

        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            VaccinationType model = new VaccinationType();
            
            if (id.HasValue)
            {
                
                VaccinationType feed = _repo.VaccinationTypes.GetById(id.Value);
               
                if (feed != null)
                {
                    model = feed;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, VaccinationType model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = false;
                    //FeedFooder feed = isNew ? new FeedFooder { } : _repo.GetById(id.Value);
                    // feed = model;
                    if (!id.HasValue)
                    {
                       // model.UpdatedBy = "admin";
                        isNew = true;
                    }
                    if (isNew)
                    {

                        model.id = 0;
                        //model.UpdatedBy = "Admin";
                      //  model.UpdatedAt = DateTime.Now;
                        _repo.VaccinationTypes.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        //To Avoid tracking error
                        // DbContextInMemory.Entry(entity).State = EntityState.Detached;
                        _repo.VaccinationTypes.Update(model);
                    }
                }
                else
                {
                    
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
        public IActionResult DeleteBreed(int id)
        {
            VaccinationType feed = _repo.VaccinationTypes.GetById(id);
            _repo.VaccinationTypes.Delete(id);

            return RedirectToAction("Index");

        }
    }
}