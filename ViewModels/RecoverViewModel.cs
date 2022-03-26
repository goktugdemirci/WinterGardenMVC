using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinterGardenMVC.ViewModels
{
    public class RecoverViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Can't be null or empty.")]
        public string Email { get; set; }
    }
}