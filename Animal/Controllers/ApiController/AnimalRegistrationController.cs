using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Animal.Dtos;
using Animal.Models;
using Animal.Models.ViewModel;
using Animal.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Animal.Controllers.ApiController
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AnimalRegistrationController : ControllerBase
    {
        private readonly IUnitOfWork _repo;
        private readonly IHostingEnvironment _host;
        private readonly IMapper _mapper;


        public AnimalRegistrationController(IUnitOfWork repo, IHostingEnvironment host, IMapper mapper)
        {
            _host = host;
            _repo = repo;
            _mapper = mapper;
        }
       
        [HttpGet("details")]
        public IActionResult Details(int id)
        {
            AnimalRegistration feed = _repo.AnimalRegistration.GetById(id);
          
            var animalDto = _mapper.Map<AnimalRegistrationDto>(feed);
            if (feed != null)
            {
                animalDto.DefaultImageUrl = Path.Combine(_host.WebRootPath, "\\images\\cow.png");
                animalDto.ImageUrl = Path.Combine(_host.WebRootPath, "\\images\\animal\\" + feed.earTagNo + ".jpg");
            }

            return Ok(animalDto);
        }

        
        [HttpPost("AddEditAnimal")]
        public ActionResult AddEditAnimal(int? id, [FromForm]AnimalVM model, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    if (isNew)
                    {
                        //var config = new MapperConfiguration(cfg =>
                        //{
                        //    cfg.CreateMap<AnimalVM, AnimalRegistration>();
                        //});

                        //IMapper iMapper = config.CreateMapper();
                        AnimalRegistration animal = _mapper.Map<AnimalRegistration>(model);
                        animal.createdAt = DateTime.Now.ToShortDateString();
                        animal.EarTag = _repo.EarTag.GetByTag(model.earTagNo);
                        animal.earTagId = animal.EarTag.id;
                        _repo.AnimalRegistration.Insert(animal);
                        _repo.Save();
                        var path = _host.WebRootPath + "\\images\\animal\\";

                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        if (file != null)
                        {

                            var fileName = Path.Combine(path, animal.earTagNo + ".jpg");
                            file.CopyTo(new FileStream(fileName, FileMode.Create));
                        }
                    }
                    else
                    {
                       

                        AnimalRegistration animal = _mapper.Map<AnimalRegistration>(model);
                        animal.EarTag = _repo.EarTag.GetByTag(model.earTagNo);
                        animal.earTagId = animal.EarTag.id;
                        animal.updatedBy = "admin";

                        _repo.AnimalRegistration.Update(animal);
                    }
                }
                else
                {
                    //model.speciess = new SelectList(_repo.Species.GetModel(), "id", "speciesName", model.speciesId);
                    //model.breeds = new SelectList(_repo.Breed.GetModel(), "id", "breedNameShort", model.breedId);
                    //model.owners = new SelectList(_repo.OwnerKeeper.GetModel(), "id", "fullName", model.ownerId);
                    //model.keepers = new SelectList(_repo.keepers.GetModel(), "id", "fullName", model.keeperId);
                    //model.farms = new SelectList(_repo.Farm.GetModel(), "id", "orgtanizationName", model.farmId);
                    //model.dams = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender == "Male"), "id", "earTagNo", model.damId);
                    //model.sires = new SelectList(_repo.AnimalRegistration.GetModel().Where(m => m.gender == "Female"), "id", "earTagNo", model.sireId);
                    model.declaredDate = DateTime.Now.Date;
                    return BadRequest(model);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

           // AnimalRegistration animal = _repo.AnimalRegistration.

            return Ok(model);
        }





        [HttpDelete("deleteanimal/{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            AnimalRegistration feed = _repo.AnimalRegistration.GetById(id);
            _repo.AnimalRegistration.Delete(id);

            return Ok(feed);

        }
    }
}
