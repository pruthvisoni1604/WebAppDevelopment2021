using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_DynamicDevelopers.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a valid firstname.")]
        [Range(1, 51)]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a valid lastname.")]
        [Range(1, 51)]
        public string Lastname { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage ="Please enter a valid address.")]
        [Range(1, 51)]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter a valid City.")]
        [Range(1, 51)]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter a valid state.")]
        [Range(1, 51)]
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Please enter a valid postalcode.")]
        [Range(1,21)]
        public string Postalcode { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter a valid email.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Emailaddress is not valid")]
        public string Email { get; set; }


        public int CountryId { get; set; }

        [Display(Name = "Select a Country..")]
        [Range(1, 10, ErrorMessage = "Please select a country.")]
        [Required(ErrorMessage = "Please select a country.")]
        public Country Country { get; set; }

        [Display(Name = "Phonenumber")]
        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Phone number is not valid")]
        public string  Phone { get; set; }
    }
}
