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
    public class DiseasesController : Controller
    {
        private readonly IUnitOfWork _repo;

        public DiseasesController(IUnitOfWork repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            IEnumerable<Diseases> all = _repo.Diseases.GetModel();
            return View(all);
        }

        public IActionResult Details(int id)
        {
            Diseases feed = _repo.Diseases.GetById(id);
            return View(feed);

        }

        [HttpGet]
        public IActionResult AddEditAnimal(int? id)
        {
            Diseases model = new Diseases();
            
            if (id.HasValue)
            {
                
                Diseases feed = _repo.Diseases.GetById(id.Value);
               
                if (feed != null)
                {
                    model = feed;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditAnimal(int? id, Diseases model)
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
                        //model.UpdatedAt = DateTime.Now;
                        _repo.Diseases.Insert(model);
                        _repo.Save();
                    }
                    else
                    {
                        //To Avoid tracking error
                        // DbContextInMemory.Entry(entity).State = EntityState.Detached;
                        _repo.Diseases.Update(model);
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
            Diseases feed = _repo.Diseases.GetById(id);
            _repo.Diseases.Delete(id);

            return RedirectToAction("Index");

        }
    }
}