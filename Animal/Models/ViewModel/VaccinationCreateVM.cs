using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class VaccinationCreateVM
    {
        public int id { get; set; }
        public string vaccinName { get; set; }
        public int vaccinTypeId { get; set; }
        public int? vaccinationSubTypeId { get; set; }
        public string vaccinForm { get; set; }
        public string manufacturedBy { get; set; }

        public SelectList VaccinationTypes { get; set; }
        public SelectList VaccinationSubTypes { get; set; }
    }
}
