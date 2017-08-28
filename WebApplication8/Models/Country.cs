using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication8.Models
{
    public class Country
    {
        [Key]
        public int country_id { get; set; }
        public string country_name { get; set; }
    }

}
