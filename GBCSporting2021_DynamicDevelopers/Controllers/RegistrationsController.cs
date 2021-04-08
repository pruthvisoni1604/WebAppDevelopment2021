using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GBCSporting2021_DynamicDevelopers.Models;
using GBCSporting2021_DynamicDevelopers.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting2021_DynamicDevelopers.Controllers
{
    public class RegistrationsController : Controller
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public RegistrationsController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetCustomer()
        {
            ViewData["CutomerId"] = new SelectList(_context.Customers, "CustomerId", "Firstname");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> List(string CustomerId)
        {

            List<RegistrationViewModel> registration = new List<RegistrationViewModel>();
            var context = await _context.Registration.Include(i => i.Product).Include(i => i.Customer).Where(x => x.CustomerId == Int32.Parse(CustomerId)).ToListAsync();
            List<RegistrationViewModel> registrationViewModel = _mapper.Map<List<RegistrationViewModel>>(context);

            return View(registrationViewModel);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = (from item in _context.Incidents
                            join product in _context.Products on item.ProductId equals product.ProductId
                            join technician in _context.Technicians on item.TechnicianId equals technician.TechnicianId
                            join customer in _context.Customers on item.CustomerId equals customer.CustomerId
                            select new IncidentUpdateViewModel
                            {
                                IncidentId = item.IncidentId,
                                CustomerId = item.CustomerId,
                                ProductId = item.ProductId,
                                title = item.title,
                                Description = item.Description,
                                Dateopened = item.Dateopened,
                                TechName = technician.Technicianname,
                                ProductName = product.Productname,
                                CustomerName = String.Concat(customer.Firstname, customer.Lastname)
                            }).FirstOrDefault(x => x.IncidentId == id);
            if (incident == null)
            {
                return NotFound();
            }
            return View(incident);
        }
    }
}