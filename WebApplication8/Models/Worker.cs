using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication8.Models
{
    public class Worker
    {

        [Key]
        public int empid { get; set; }

        [Required]
        [Display(Name = "Your Name")]
        public string empname { get; set; }

        [Required]
        [Display(Name = "Your Email")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Select Country")]
        public string country_name { get; set; }

        [Required]
        [Display(Name = "Select State")]
        public string state_name { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Enter Address")]
        public string Address { get; set; }

    }
}