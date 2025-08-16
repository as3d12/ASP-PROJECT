using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eagle.Data;
using Eagle.Models;
using Eagle.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using System.Drawing.Printing;

namespace Eagle.Controllers
{

    [Authorize(Roles = clsRoles.roleAdmin)]
    public class TripCompaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TripCompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

		public async Task<IActionResult> CompaniesAvgPrice()
		{
			var tripCompany = await _context.TripCompany.Include(t => t.Company).Include(t => t.Trip).ToListAsync();
            List<CompanyAvgPricePerTrip> cl = new List<CompanyAvgPricePerTrip>();
			var groupings = tripCompany.GroupBy(
                x => x.Company.Name, 
                (companyName, tc) => new {
                    Key = companyName,
                    trips = tc.Where( e => e.Company.Name == companyName ).GroupBy(
                            y => y.Trip.Description,
                            (tripDescription, tc2) => new {
                                Key = tripDescription,
                                AvgPrice = tc2.Select(g => g.Trip.Price).Aggregate((total, next) => total + next ) / tc2.Count()
                            }
                        ).ToDictionary(g => g.Key, g=> g.AvgPrice)
                }
                );

            foreach(var g in groupings)
            {
                cl.Add(new CompanyAvgPricePerTrip
                {
                    CompanyName = g.Key,
                    trips = g.trips,

                });
            }
            Console.WriteLine(groupings);

            return View(cl);
		}

		// GET: TripCompanies
		public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TripCompany.Include(t => t.Company).Include(t => t.Trip);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TripCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tripCompany = await _context.TripCompany
                .Include(t => t.Company)
                .Include(t => t.Trip)
                .FirstOrDefaultAsync(m => m.TripCompanyId == id);
            if (tripCompany == null)
            {
                return NotFound();
            }

            return View(tripCompany);
        }

        // GET: TripCompanies/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.tblCompany, "CompanyId", "Email");
            ViewData["TripId"] = new SelectList(_context.tblTrip, "TripId", "Description");
            return View();
        }

        // POST: TripCompanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TripCompanyId,CompanyId,TripId,Responsible,Status")] TripCompany tripCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tripCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.tblCompany, "CompanyId", "Email", tripCompany.CompanyId);
            ViewData["TripId"] = new SelectList(_context.tblTrip, "TripId", "Description", tripCompany.TripId);
            return View(tripCompany);
        }

        // GET: TripCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tripCompany = await _context.TripCompany.FindAsync(id);
            if (tripCompany == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.tblCompany, "CompanyId", "Email", tripCompany.CompanyId);
            ViewData["TripId"] = new SelectList(_context.tblTrip, "TripId", "Description", tripCompany.TripId);
            return View(tripCompany);
        }

        // POST: TripCompanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TripCompanyId,CompanyId,TripId,Responsible,Status")] TripCompany tripCompany)
        {
            if (id != tripCompany.TripCompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tripCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TripCompanyExists(tripCompany.TripCompanyId))
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
            ViewData["CompanyId"] = new SelectList(_context.tblCompany, "CompanyId", "Email", tripCompany.CompanyId);
            ViewData["TripId"] = new SelectList(_context.tblTrip, "TripId", "Description", tripCompany.TripId);
            return View(tripCompany);
        }

        // GET: TripCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tripCompany = await _context.TripCompany
                .Include(t => t.Company)
                .Include(t => t.Trip)
                .FirstOrDefaultAsync(m => m.TripCompanyId == id);
            if (tripCompany == null)
            {
                return NotFound();
            }

            return View(tripCompany);
        }

        // POST: TripCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tripCompany = await _context.TripCompany.FindAsync(id);
            if (tripCompany != null)
            {
                _context.TripCompany.Remove(tripCompany);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TripCompanyExists(int id)
        {
            return _context.TripCompany.Any(e => e.TripCompanyId == id);
        }
    }
}
