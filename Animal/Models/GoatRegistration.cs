using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models
{
    [Table("dbug_goat")]
    public class GoatRegistration
    {
        public int id { get; set; }
        public string earTagNo { get; set; }
        public int? GoatBreedId { get; set; }
        public virtual GoatBreed GoatBreed { get; set; }
        public string OriginOf { get; set; }
        public string Weather { get; set; }
        public string MainPurpose { get; set; }
        public string Availability { get; set; }
        public string FeedingNature { get; set; }
        public decimal FirstPregnancyTime { get; set; }
        public decimal  WeightOnBirth { get; set; }
        public decimal GrowthRateWt { get; set; }
        public decimal PregnancyDuration { get; set; }
        public decimal AverageWtFemale { get; set; }
        public decimal AverageWtMale { get; set; }
        public string Siration { get; set; }
        public int NoOfBaby { get; set; }
        public decimal PurchasePerKg { get; set; }
        public decimal PricePerKg { get; set; }
        public decimal PricePerKgDam { get; set; }
        public string MarketPlace { get; set; }
        public decimal FeedingExpense { get; set; }
        public decimal MscExpense { get; set; }
        public decimal PasminaProduction { get; set; }
        public decimal PasminaPrice { get; set; }
        public decimal FertilizerWt { get; set; }
        public decimal FertilizerPrice { get; set; }
        public int DurationForWt { get; set; }
        public string UpdatedBy { get; set; } = "Admin";
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
