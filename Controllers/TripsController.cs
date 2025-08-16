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

namespace Eagle.Controllers
{
    [Authorize(Roles = clsRoles.roleAdmin)]
    public class TripsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TripsController(ApplicationDbContext context)
        {
            _context = context;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> FindBy(int? id, string name)
        {
            var sections = await _context.tblSection.ToListAsync();
            sections.Add(new Section { SectionId = -1, Name = "Select Section" });
            ViewData["SectionId"] = new SelectList(sections, "SectionId", "Name", id ?? -1);

            var model = new TripsViewModel();

            // If SectionId is provided, filter trips by SectionId
            if (id.HasValue && id.Value != -1)
            {
                model.Trips = await _context.tblTrip
                    .Include(t => t.Section)
                    .Where(t => t.SectionId == id.Value)
                    .ToListAsync();


                if (name == "Best")
                {
                    model.Trips = await _context.tblTrip.Include(t => t.Section)
                        .Where(t => t.SectionId == id.Value).OrderByDescending(t => t.Price).ToListAsync();
                }
                if (name == "Cheapest")
                {
                    model.Trips = await _context.tblTrip.Include(t => t.Section)
                        .Where(t => t.SectionId == id.Value).OrderBy(t => t.Price).ToListAsync();
                }
            }


            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> FindBy(TripsViewModel model, int? id, string name)
        {
            var sections = await _context.tblSection.ToListAsync();
            sections.Add(new Section { SectionId = -1, Name = "Select Section" });
            ViewData["SectionId"] = new SelectList(sections, "SectionId", "Name", id ?? -1);

            // Base query to get trips, including the section filter if SectionId is provided
            IQueryable<Trip> query = _context.tblTrip.Include(t => t.Section);


            if (id.HasValue && id.Value != -1)
            {
                query = query.Where(t => t.SectionId == id.Value);
            }

            if (model.Name != default)
            {
                query = query.Where(t => t.Name == model.Name);
            }

            if (model.Description != default)
            {
                query = query.Where(t => t.Description == model.Description);
            }
            // Apply date filters
            if (model.StartDate != default)
            {
                query = query.Where(t => t.StartDate >= model.StartDate);
            }
            if (model.EndDate != default)
            {
                query = query.Where(t => t.EndDate <= model.EndDate);
            }

            // Apply price filter
            if (model.Price > 0)
            {
                query = query.Where(t => t.Price == model.Price);
            }

            if (name == "Best")
            {
                query = query.OrderByDescending(t => t.Price);
            }
            if (name == "Cheapest")
            {
                query = query.OrderBy(t => t.Price);
            }

            model.Trips = await query.ToListAsync();
            return View(model);


        }


        // GET: Trips
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.tblTrip.Include(t => t.Section);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Trips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.tblTrip
                .Include(t => t.Section)
                .FirstOrDefaultAsync(m => m.TripId == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // GET: Trips/Create
        public IActionResult Create()
        {
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name");
            return View();
        }

        // POST: Trips/Create
        // Description protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TripId,Name,Description,StartDate,EndDate,StartTime,EndTime,Price,SectionId")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", trip.SectionId);
            return View(trip);
        }

        // GET: Trips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.tblTrip.FindAsync(id);
            if (trip == null)
            {
                return NotFound();
            }
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", trip.SectionId);
            return View(trip);
        }

        // POST: Trips/Edit/5
        // Description protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TripId,Name,Description,StartDate,EndDate,StartTime,EndTime,Price,SectionId")] Trip trip)
        {
            if (id != trip.TripId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TripExists(trip.TripId))
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
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", trip.SectionId);
            return View(trip);
        }

        // GET: Trips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.tblTrip
                .Include(t => t.Section)
                .FirstOrDefaultAsync(m => m.TripId == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trip = await _context.tblTrip.FindAsync(id);
            if (trip != null)
            {
                _context.tblTrip.Remove(trip);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TripExists(int id)
        {
            return _context.tblTrip.Any(e => e.TripId == id);
        }
    }
}
