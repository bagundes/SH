using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandPage.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Passwd { get; set; }

        [DisplayName("Remember")]
        public bool Remember { get; set; }
    }
}
