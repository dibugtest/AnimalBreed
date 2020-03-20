using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class VaccinationIndexVM
    {
        public Vaccination Vaccination { get; set; }
        public VaccinationType Type { get; set; }
        public VaccinationSubType SubType { get; set; }
    }
}
