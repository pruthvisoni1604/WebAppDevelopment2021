using GBCSporting2021_DynamicDevelopers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_DynamicDevelopers.ViewModel
{
    public class IncidentsViewModel
    {
        public int IncidentId { get; set; }
        public int CustomerId { get; set; }
        [Range(1, 10, ErrorMessage = "Please select a customer.")]
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        [Range(1, 10, ErrorMessage = "Please select a product.")]
        public Product Product { get; set; }
        public int TechnicianId { get; set; }
        [Range(1, 10, ErrorMessage = "Please select a technician.")]
        public Technician Technician { get; set; }
        [Required(ErrorMessage = "Please enter a valid title.")]
        public string title { get; set; }
        [Required(ErrorMessage = "Please enter a valid Description.")]
        public string Description { get; set; }
        public DateTime Dateopened { get; set; }
        public DateTime Dateclosed { get; set; }

        public string TechName { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
    }

    public class IncidentUpdateViewModel
    {
        public int IncidentId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TechnicianId { get; set; }
        public Technician Technician { get; set; }
        public string title { get; set; }
        [Required(ErrorMessage = "Please enter a valid Description.")]
        public string Description { get; set; }
        public DateTime Dateopened { get; set; }
        public DateTime Dateclosed { get; set; }

        public string TechName { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
    }

}
