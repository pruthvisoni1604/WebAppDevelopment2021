using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_DynamicDevelopers.Models
{
    public class Technician
    {
        public int TechnicianId { get; set; }
        [Required(ErrorMessage ="Please enter a valid technician name.")]
        public string Technicianname { get; set; }
        [Required(ErrorMessage = "Please enter a valid technician email.")]
        public string Technicianemail { get; set; }
        [Required(ErrorMessage = "Please enter a valid technician phone.")]
        public string Technicianphone { get; set; }
    }
}
