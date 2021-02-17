using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Please enter a valid code.")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please enter a valid product name.")]
        public string Productname { get; set; }
        [Required(ErrorMessage = "Please enter a valid product price.")]
        public double Productprice{ get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
