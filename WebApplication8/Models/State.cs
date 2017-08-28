using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication8.Models
{
    public class State
    {

        public int country_id { get; set; }
        [Key]
        public int state_id { get; set; }
        public string state_name { get; set; }

    }
}