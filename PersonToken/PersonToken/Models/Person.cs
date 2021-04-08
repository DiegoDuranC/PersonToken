using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonToken.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        public int CovidCount { get; set; }
    }
}