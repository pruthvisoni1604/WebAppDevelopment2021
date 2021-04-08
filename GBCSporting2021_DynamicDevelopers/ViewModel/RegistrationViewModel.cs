using GBCSporting2021_DynamicDevelopers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_DynamicDevelopers.ViewModel
{
    public class RegistrationViewModel
    {
        public int CustomerId { get; set; }
        [Range(1, 10, ErrorMessage = "Please select a customer.")]
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        [Range(1, 10, ErrorMessage = "Please select a product.")]
        public Product Product { get; set; }
    }
}
