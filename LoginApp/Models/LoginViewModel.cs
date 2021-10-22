using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Proszę podać nazwę uzytkownika.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Prosze podac hasło.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}