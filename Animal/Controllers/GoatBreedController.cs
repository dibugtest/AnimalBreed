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
    public class GoatBreedController : Controller
    {
        private readonly IUnitOfWork _repo;

        public GoatBreedController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            IEnumerable<GoatBreed> all = _repo.GoatBreed.GetModel();
            return View(all);
        }

        public IActionResult Details(int id)
        {
            GoatBreed feed = _repo.GoatBreed.GetById(id);
            return View(feed);

        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            GoatBreed model = new GoatBreed();
            
            if (id.HasValue)
            {
                
                GoatBreed feed = _repo.GoatBreed.GetById(id.Value);
               
                if (feed != null)
                {
                    model = feed;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, GoatBreed model)
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
                        model.UpdatedBy = "admin";
                        isNew = true;
                    }
                    if (isNew)
                    {

                        model.Id = 0;
                        model.UpdatedBy = "Admin";
                        model.UpdatedAt = DateTime.Now;
                        _repo.GoatBreed.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        //To Avoid tracking error
                        // DbContextInMemory.Entry(entity).State = EntityState.Detached;
                        _repo.GoatBreed.Update(model);
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
            GoatBreed feed = _repo.GoatBreed.GetById(id);
            _repo.GoatBreed.Delete(id);

            return RedirectToAction("Index");

        }
    }
}