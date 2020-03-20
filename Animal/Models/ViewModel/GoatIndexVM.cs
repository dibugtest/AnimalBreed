using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{ 
    public class GoatIndexVM
    {
        public GoatRegistration Goat { get; set; }
        public GoatBreed Breed { get; set; }
    }
}
