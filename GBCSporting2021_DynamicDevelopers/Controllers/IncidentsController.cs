using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GBCSporting2021_DynamicDevelopers.Models;
using GBCSporting2021_DynamicDevelopers.ViewModel;
using AutoMapper;

namespace GBCSporting2021_DynamicDevelopers.Controllers
{
    public class IncidentsController : Controller
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public IncidentsController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Incidents
        public async Task<IActionResult> Index()
        {
            List<IncidentsViewModel> incidents = new List<IncidentsViewModel>();
            var context =await _context.Incidents.Include(i => i.Customer).Include(i => i.Product).Include(i => i.Technician).ToListAsync();
            List<IncidentsViewModel> incidentsViewModel = _mapper.Map<List<IncidentsViewModel>>(context);
            return View(incidentsViewModel);
        }

        // GET: Incidents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = await _context.Incidents
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .Include(i => i.Technician)
                .FirstOrDefaultAsync(m => m.IncidentId == id);
            if (incident == null)
            {
                return NotFound();
            }
            IncidentsViewModel incidentsViewModel = _mapper.Map<IncidentsViewModel>(incident);

            return View(incidentsViewModel);
        }

        // GET: Incidents/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Address");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Code");
            ViewData["TechnicianId"] = new SelectList(_context.Technicians, "TechnicianId", "Technicianemail");
            return View();
        }

        // POST: Incidents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncidentId,CustomerId,ProductId,TechnicianId,title,Description,Dateopened,Dateclosed")] IncidentsViewModel incidentVM)
        {
            if (ModelState.IsValid)
            {
                Incident incident = new Incident();
                incident = _mapper.Map<Incident>(incidentVM);
                _context.Add(incident);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Address", incidentVM.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Code", incidentVM.ProductId);
            ViewData["TechnicianId"] = new SelectList(_context.Technicians, "TechnicianId", "Technicianemail", incidentVM.TechnicianId);
            return View(incidentVM);
        }

        // GET: Incidents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = await _context.Incidents.FindAsync(id);
            IncidentsViewModel incidentsViewModel = _mapper.Map<IncidentsViewModel>(incident);

            if (incident == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Address", incident.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Code", incident.ProductId);
            ViewData["TechnicianId"] = new SelectList(_context.Technicians, "TechnicianId", "Technicianemail", incident.TechnicianId);
            return View(incidentsViewModel);
        }

        // POST: Incidents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncidentId,CustomerId,ProductId,TechnicianId,title,Description,Dateopened,Dateclosed")] IncidentsViewModel incidentVM)
        {
            if (id != incidentVM.IncidentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Incident incident = new Incident();
                    incident = _mapper.Map<Incident>(incidentVM);

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
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Address", incidentVM.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Code", incidentVM.ProductId);
            ViewData["TechnicianId"] = new SelectList(_context.Technicians, "TechnicianId", "Technicianemail", incidentVM.TechnicianId);
            return View(incidentVM);
        }

        // GET: Incidents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var incident = await _context.Incidents
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .Include(i => i.Technician)
                .FirstOrDefaultAsync(m => m.IncidentId == id);
            if (incident == null)
            {
                return NotFound();
            }

            return View(incident);
        }

        // POST: Incidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var incident = await _context.Incidents.FindAsync(id);
            _context.Incidents.Remove(incident);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncidentExists(int id)
        {
            return _context.Incidents.Any(e => e.IncidentId == id);
        }

    }
}
