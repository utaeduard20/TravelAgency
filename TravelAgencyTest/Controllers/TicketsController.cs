using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelAgencyTest.Data;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Controllers
{
    [AllowAnonymous]
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tickets.Include(t => t.AirlineCompany).Include(t => t.Holiday);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tickets/Details/5

        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.AirlineCompany)
                .Include(t => t.Holiday)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        [Authorize(Roles = "User, Admin")]
        public IActionResult Create()
        {
            ViewData["AirlineId"] = new SelectList(_context.AirlineCompanies, "AirlineId", "AirlineId");
            ViewData["HolidayId"] = new SelectList(_context.Holidays, "HolidayId", "HolidayId");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "User, Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketId,Price,Departure,Arrival,Duration,HolidayId,AirlineId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AirlineId"] = new SelectList(_context.AirlineCompanies, "AirlineId", "AirlineId", ticket.AirlineId);
            ViewData["HolidayId"] = new SelectList(_context.Holidays, "HolidayId", "HolidayId", ticket.HolidayId);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["AirlineId"] = new SelectList(_context.AirlineCompanies, "AirlineId", "AirlineId", ticket.AirlineId);
            ViewData["HolidayId"] = new SelectList(_context.Holidays, "HolidayId", "HolidayId", ticket.HolidayId);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "User, Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,Price,Departure,Arrival,Duration,HolidayId,AirlineId")] Ticket ticket)
        {
            if (id != ticket.TicketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketId))
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
            ViewData["AirlineId"] = new SelectList(_context.AirlineCompanies, "AirlineId", "AirlineId", ticket.AirlineId);
            ViewData["HolidayId"] = new SelectList(_context.Holidays, "HolidayId", "HolidayId", ticket.HolidayId);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.AirlineCompany)
                .Include(t => t.Holiday)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [Authorize(Roles = "User, Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.TicketId == id);
        }
    }
}
