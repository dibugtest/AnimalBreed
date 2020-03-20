using Animal.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Animal.Repository
{
    public class VaccinationRepository : Repository<Vaccination>, IVaccinationRepository
    {

        public VaccinationRepository(AnimalContext Context)
            : base(Context)
        {
        }

        public AnimalContext AnimalContext
        {
            get { return db as AnimalContext; }

        }

        public IEnumerable<Vaccination> GetModel()
        {
            return db.vaccinations.Include(M => M.vaccinationType).Include(m => m.vaccinationSubType).ToList();

        }
        public Vaccination GetById(int id)
        {
            return db.vaccinations.Include(m => m.vaccinationType).Include(m => m.vaccinationSubType).FirstOrDefault(m => m.id == id);

        }

    }
}
