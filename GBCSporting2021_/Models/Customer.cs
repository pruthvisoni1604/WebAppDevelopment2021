using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter a valid firstname.")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Please enter a valid lastname.")]
        public string Lastname { get; set; }
        [Required(ErrorMessage ="Please enter a valid address.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter a valid City.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a valid state.")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a valid postalcode.")]
        public string Postalcode { get; set; }
        [Required(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }
        public int CountryId { get; set; }
        [Range(1, 10, ErrorMessage = "Please select a country.")]
        public Country Country { get; set; }
        [Required(ErrorMessage = "Please enter a valid email.")]
        public string  Phone { get; set; }
    }
}
