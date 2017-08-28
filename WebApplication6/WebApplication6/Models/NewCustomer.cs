using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class NewCustomer
    {
        [Key]
        [Required]
        public string Id { get; set; }

        [Required]
        [Display(Name = " Enter Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = " Enter Email")]
        public string email { get; set; }


        [Display(Name = "News letter Status")]
        public bool NewsLetter { get; set; }

       [Required]
        public string state { get; set; }
    }
}