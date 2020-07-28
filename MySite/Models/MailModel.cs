using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySite.Models
{
    public class MailModel
    {

        [Required(ErrorMessage = "Email is required.")]
        // [E(ErrorMessage = "Invalid Email Address.")]
        public string To
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }
    }
}