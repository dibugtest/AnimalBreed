using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class VaccinAnimalIndexVM
        
    {
        public Vaccination Vaccin { get; set; }
        public VaccinationAnimal Animal { get; set; }
        public Diseases diseases { get; set; }
    }
}
