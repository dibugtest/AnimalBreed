using Animal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public class GoatBreedReporitory : Repository<GoatBreed>, IGoatBreedRepository
    {

        public GoatBreedReporitory(AnimalContext Context)
            : base(Context)
        {
        }

        public AnimalContext AnimalContext
        {
            get { return db as AnimalContext; }

        }

    }
}
