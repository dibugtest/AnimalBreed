using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class VaccinationSubTypeVM
    {
        public int id { get; set; }
        public string SubTypeName { get; set; }
        public int VaccinationTypeId { get; set; }
        public SelectList VaccinationTypes { get; set; }
    }
}
