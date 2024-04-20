using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegistration.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        public string? UserEmail { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

    }
}
