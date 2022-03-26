using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinterGardenMVC.ViewModels
{
    public class LoginViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Unvalid Username or E-mail")]
        public string Credential { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password can't be null")]
        public string Password { get; set; }
    }
}