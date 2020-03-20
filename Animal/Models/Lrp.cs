using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models
{
    [Table("dbug_lrpUser")]
    public class Lrp
    {
        public int id { get; set; }
        [Required]
        public string fullName { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string provience { get; set; }
        public string munipalicity { get; set; }
        public string area { get; set; }
        public ICollection<Farm> Farms { get; set; }
    }

}
