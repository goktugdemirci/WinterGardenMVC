using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WinterGardenMVC.Models
{
    public class Admin
    {
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "50 Characters Maximum")]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "50 Characters Maximum")]
        public string Password { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "50 Characters Maximum")]
        public string Firstname { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "50 Characters Maximum")]
        public string Surname { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "50 Characters Maximum")]
        public string Email { get; set; }
        [Required]
        public bool isAdmin { get; set; }
        [Required]
        public bool isEditor { get; set; }
        [Required]
        public bool isDeleted { get; set; }

    }
}