using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TravelAgencyTest.Data;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Controllers
{
    //[Authorize(Roles = "User, Admin")]
    
    public class AirlineCompaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirlineCompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AirlineCompanies
        //[Authorize(Roles = "User, Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.AirlineCompanies.ToListAsync());
        }



        // GET: AirlineCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airlineCompany = await _context.AirlineCompanies
                .FirstOrDefaultAsync(m => m.AirlineId == id);
            if (airlineCompany == null)
            {
                return NotFound();
            }

            return View(airlineCompany);
        }

        // GET: AirlineCompanies/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirlineCompanies/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AirlineId,Name")] AirlineCompany airlineCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airlineCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airlineCompany);
        }

        [Authorize(Roles = "Admin")]
        // GET: AirlineCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airlineCompany = await _context.AirlineCompanies.FindAsync(id);
            if (airlineCompany == null)
            {
                return NotFound();
            }
            return View(airlineCompany);
        }

        // POST: AirlineCompanies/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AirlineId,Name")] AirlineCompany airlineCompany)
        {
            if (id != airlineCompany.AirlineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airlineCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirlineCompanyExists(airlineCompany.AirlineId))
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
            return View(airlineCompany);
        }

        // GET: AirlineCompanies/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airlineCompany = await _context.AirlineCompanies
                .FirstOrDefaultAsync(m => m.AirlineId == id);
            if (airlineCompany == null)
            {
                return NotFound();
            }

            return View(airlineCompany);
        }

        // POST: AirlineCompanies/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airlineCompany = await _context.AirlineCompanies.FindAsync(id);
            _context.AirlineCompanies.Remove(airlineCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirlineCompanyExists(int id)
        {
            return _context.AirlineCompanies.Any(e => e.AirlineId == id);
        }
    }
}
