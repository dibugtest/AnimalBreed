using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class GoatSelectionVM
    {
        public IEnumerable<GoatIndexVM> GoatIndex { get; set; }
        public string GoatBreed { get; set; }
        public SelectList GoatBreeds { get; set; }

        public string OriginOf { get; set; }

        public string Weather { get; set; }
        public SelectList Weathers { get; set; }

        public string MainPurpose { get; set; }
        public SelectList MainPurposes { get; set; }

        public string Availability { get; set; }
        public SelectList Availabilities { get; set; }

        public string FeedingNature { get; set; }
        public SelectList FeedingNatures { get; set; }
        
    
        //public SelectList Sirations { get; set; }
        //public SelectList NoOfBabies { get; set; }
        public GoatSelectionVM()
        {
            Weathers = new SelectList(new List<SelectListItem>(){new SelectListItem { Value = "गर्मी" },
                new SelectListItem { Value = "चिसो" },
                new SelectListItem { Value = "चिसो" },
                new SelectListItem { Value = "सुख्खा" },
                new SelectListItem { Value = "पहाडी हावापानी" },
                new SelectListItem { Value = "हिमाली हावापानी" },
                new SelectListItem { Value = "तराईको हावापानी" }
          }, "Value", "Value");
            MainPurposes = new SelectList(new List<SelectListItem>(){ new SelectListItem { Value = "दुध" },
                new SelectListItem { Value = "मासु" },
                new SelectListItem { Value = "दुध र मासु" },
                new SelectListItem { Value = "पश्मिना" },
                new SelectListItem { Value = "पश्मिना" },
                new SelectListItem { Value = "पश्मिना र मासु" },
                new SelectListItem { Value = "पश्मिना र दुध" },
                new SelectListItem { Value = "पश्मिना, मासु र दुध" }}, "Value", "Value");

            Availabilities = new SelectList(new List<SelectListItem>(){ new SelectListItem { Value = "स्थानीय जात" },
                new SelectListItem { Value = "बिदेशी जात" } }, "Value", "Value");
            FeedingNatures = new SelectList(new List<SelectListItem>(){  new SelectListItem { Value = "बधुवा" },
                new SelectListItem { Value = "चरण" }}, "Value", "Value");

            //Sirations = new SelectList(new List<SelectListItem>(){ new SelectListItem { Value = "पाठा" },
            //    new SelectListItem { Value = "पाठी" }}, "Value", "Value");
            //NoOfBabies = new SelectList(new List<SelectListItem>(){new SelectListItem { Value = "1",Text="एकल" },
            //    new SelectListItem {Value="2",Text = "जुम्ल्यहा" },
            //    new SelectListItem {Value="3", Text = "३" },
            //    new SelectListItem {Value="4", Text = "४" },
            //    new SelectListItem {Value="5", Text = "५" },
            //    new SelectListItem {Value="6", Text = "६" }}, "Value", "Text");

        }
    }
}
