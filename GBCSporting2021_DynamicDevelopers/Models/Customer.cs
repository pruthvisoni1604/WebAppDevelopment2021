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
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Maximum 51 characters")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a valid lastname.")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Maximum 51 characters")]
        public string Lastname { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter a valid address.")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Maximum 51 characters")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter a valid City.")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Maximum 51 characters")]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter a valid state.")]
        [StringLength(51, MinimumLength = 1, ErrorMessage = "Maximum 51 characters")]
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Please enter a valid postalcode.")]
        [StringLength(21, MinimumLength = 1, ErrorMessage = "Maximum 21 characters")]
        public string Postalcode { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter a valid email.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Emailaddress should be in  name@domain.com")]
        public string Email { get; set; }


        public int CountryId { get; set; }

        [Display(Name = "Country")]
        [Range(1, 10, ErrorMessage = "Please select a country.")]
        [Required(ErrorMessage = "Country must not be empty.")]
        public Country Country { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Phone number should be in 999-999-9999 formate.")]
        public string Phone { get; set; }
    }
}