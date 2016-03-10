using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Web.Security;

namespace SimpleMemberShip.Models
{
    public class EmailModel
    {


        [Required(ErrorMessage= "Woops! You forgot your name"), Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required(ErrorMessage = "I need your email address"), Display(Name = "Your email"), EmailAddress(ErrorMessage = "Check the format of your email address")]
        [StringLength(254, ErrorMessage = "The email address is too long!")] 
        public string FromEmail { get; set; }
        [Required(ErrorMessage = "You forget to write a message")]
        public string Message { get; set; }

    }
}