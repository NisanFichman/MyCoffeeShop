using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Enter E-Mail")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid E-Mail")]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { set; get; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must at least contain {2} characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { set; get; }
    }
}
