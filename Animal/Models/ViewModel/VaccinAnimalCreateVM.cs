using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class VaccinAnimalCreateVM
    {
        public int id { get; set; }
        public string earTagNo { get; set; }
        public string serviceProviderId { get; set; }
        public int vaccinId { get; set; }
        public SelectList Vaccinations { get; set; }

        public int diseasesId { get; set; }
        public SelectList Diseases { get; set; }

        public DateTime vaccinationDate { get; set; }
        public string dosage { get; set; }
        public string batchNo { get; set; }
        public string charge { get; set; }
        public string receiptNo { get; set; }
        public int animalId { get; set; }

        public SelectList animalRegistrations { get; set; }

    }
}
