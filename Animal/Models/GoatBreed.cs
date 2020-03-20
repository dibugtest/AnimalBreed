using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models
{
    [Table("dbug_goatBreed")]
    public class GoatBreed
    {
        public int Id { get; set; }
        [Required]
        public string  BreedName { get; set; }
        public string ShortDetails { get; set; }
        public string UpdatedBy { get; set; } = "Admin";
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public ICollection<GoatRegistration> Goats { get; set; }
    }
}
