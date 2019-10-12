using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssignmentTwo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AssignmentTwo.Controllers
{
   
    
    
    public class ScheduleMembersController : Controller
    {
        private readonly AssignmentTwoContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ScheduleMembersController(AssignmentTwoContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize(Policy = "Administrator")]
        //here admin can see all enrolled members
        // GET: ScheduleMembers
        public async Task<IActionResult> Index(string searchString)
        {
            var coaches = from coach in _context.ScheduleMembers
                          select coach;
            if (!String.IsNullOrEmpty(searchString))
            {
                coaches = coaches.Where(s => s.CoachEmail.Contains(searchString));
            }
            return View(await coaches.ToListAsync());
        }
        [Authorize(Policy = "Administrator")]
        // GET: ScheduleMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleMembers = await _context.ScheduleMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduleMembers == null)
            {
                return NotFound();
            }

            return View(scheduleMembers);
        }
        [Authorize(Policy = "Administrator")]
        // GET: ScheduleMembers/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Policy = "Administrator")]
        // POST: ScheduleMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ScheduleId,MemberEmail,CoachEmail")] ScheduleMembers scheduleMembers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduleMembers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduleMembers);
        }
        [Authorize(Policy = "Administrator")]
        // GET: ScheduleMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleMembers = await _context.ScheduleMembers.FindAsync(id);
            if (scheduleMembers == null)
            {
                return NotFound();
            }
            return View(scheduleMembers);
        }
        [Authorize(Policy = "Administrator")]
        // POST: ScheduleMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ScheduleId,MemberEmail,CoachEmail")] ScheduleMembers scheduleMembers)
        {
            if (id != scheduleMembers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduleMembers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleMembersExists(scheduleMembers.Id))
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
            return View(scheduleMembers);
        }
        [Authorize(Policy = "Administrator")]
        // GET: ScheduleMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleMembers = await _context.ScheduleMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduleMembers == null)
            {
                return NotFound();
            }

            return View(scheduleMembers);
        }
        [Authorize(Policy = "Administrator")]
        // POST: ScheduleMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scheduleMembers = await _context.ScheduleMembers.FindAsync(id);
            _context.ScheduleMembers.Remove(scheduleMembers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Allows coaches to see their enrolled members.
        // GET: Schedules/myMembers
        [Authorize]
        public ActionResult MyMembers()
        {

            var coach = _userManager.GetUserName(User);

            var schedule = _context.ScheduleMembers
                .Where(m => m.CoachEmail == coach);

            return View("MyMembers", schedule);
        }

        private bool ScheduleMembersExists(int id)
        {
            return _context.ScheduleMembers.Any(e => e.Id == id);
        }
    }
}
