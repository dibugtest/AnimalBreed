using Animal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public class VaccinationAnimalRepository : Repository<VaccinationAnimal>, IVaccinationAnimalRepository
    {

        public VaccinationAnimalRepository(AnimalContext Context)
            : base(Context)
        {
        }

        public AnimalContext AnimalContext
        {
            get { return db as AnimalContext; }

        }
        public IEnumerable<VaccinationAnimal> GetModel()
        {
            return db.vaccinationAnimals.Include(M => M.vaccination).Include(m => m.animalRegistration).Include(m=>m.diseases).ToList();
        }
        public VaccinationAnimal GetById(int id)
        {
            return db.vaccinationAnimals.Include(m => m.vaccination).Include(m => m.animalRegistration).Include(m=>m.diseases).FirstOrDefault(m => m.id == id);

        }
    }
}
