using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace DemoProject.Models
{
    public class Registration
    {
        
        int UserId { get; set; }
        [Required]
        string UserName { get; set; }
        [DisplayName("Email Address")]
        [Required]
        string Email { get; set; }
        string Address { get; set; }
        [Required]
        string Password { get; set; }
        [Compare("Password")]
        string ConfirmPassword { get; set; }
    }

   
}