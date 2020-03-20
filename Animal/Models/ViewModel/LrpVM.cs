using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Models.ViewModel
{
    public class LrpVM
    {
        public int id { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string email { get; set; }
        public string address { get; set; }
        public string provience { get; set; }
        public string munipalicity { get; set; }
        public string area { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string  password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirmPassword { get; set; }
        [Required]
        public string userName { get; set; }
        public string phoneNo { get; set; }
        public string role { get; set; } = "LRP";
        public bool permission { get; set; } = false;

    }
}
