using Animal.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public class VaccinationSubTypeRepository : Repository<VaccinationSubType>, IVaccinationSubTypeRepository
    {

        public VaccinationSubTypeRepository(AnimalContext Context)
            : base(Context)
        {
        }

        public AnimalContext AnimalContext
        {
            get { return db as AnimalContext; }

        }
        public IEnumerable<VaccinationSubType> GetModel()
        {
            return db.vaccinationSubType.Include(M => M.VaccinationType).ToList();

        }
        public VaccinationSubType GetById(int id)
        {
            return db.vaccinationSubType.Include(m => m.VaccinationType).FirstOrDefault(m => m.id == id);

        }

    }
}
