using AutoMapper;
using GBCSporting2021_DynamicDevelopers.Models;
using GBCSporting2021_DynamicDevelopers.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_DynamicDevelopers.Controllers
{
    public class TechIncident : Controller
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public TechIncident(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            ViewData["TechnicianId"] = new SelectList(_context.Technicians, "TechnicianId", "Technicianemail");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> List(string TechnicianId)
        {

            List<IncidentsViewModel> incidents = new List<IncidentsViewModel>();
            var context = await _context.Incidents.Include(i => i.Customer).Include(i => i.Product).Include(i => i.Technician).Where(x=>x.TechnicianId==Int32.Parse(TechnicianId)).ToListAsync();
            List<IncidentsViewModel> incidentsViewModel = _mapper.Map<List<IncidentsViewModel>>(context);

            return View(incidentsViewModel);
        }


        // GET: Incidents/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var incident = await _context.Incidents.FindAsync(id);
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
                                CustomerName = String.Concat(customer.Firstname,customer.Lastname)
                            }).FirstOrDefault(x=>x.IncidentId==id);


           // IncidentsViewModel incidentVM = _mapper.Map<IncidentsViewModel>(incident);

            if (incident == null)
            {
                return NotFound();
            }
            return View(incident);
        }

        // POST: Incidents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, [Bind("IncidentId,CustomerId,ProductId,TechnicianId,title,Description,Dateopened,Dateclosed")] IncidentUpdateViewModel incidentVM)
        {
          
            if (ModelState.IsValid)
            {
                try
                {

                    var incident = await _context.Incidents.FindAsync(id);
                    incident.Description = incidentVM.Description;
                    incident.Dateclosed = incidentVM.Dateclosed.ToString();

                    _context.Update(incident);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncidentExists(incidentVM.IncidentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Get));
            }

            return View(incidentVM);
        }

        private bool IncidentExists(int id)
        {
            return _context.Incidents.Any(e => e.IncidentId == id);
        }
    }
}
