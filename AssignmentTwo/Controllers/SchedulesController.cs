using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssignmentTwo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.IO;

namespace AssignmentTwo.Controllers
{
    [Authorize]
    public class SchedulesController : Controller
    {
        private readonly AssignmentTwoContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _session;

        public SchedulesController(AssignmentTwoContext context, UserManager<IdentityUser> userManager, IHttpContextAccessor session)
        {
            _context = context;
            _userManager = userManager;
            _session = session;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
            return View(await _context.Schedule.ToListAsync());
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }
        [Authorize(Policy = "Administrator")]
        // GET: Schedules/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Policy = "Administrator")]
        // POST: Schedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,When,Description,CoachEmail,Location")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }
        [Authorize(Policy = "Administrator")]
        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }
        [Authorize(Policy = "Administrator")]
        // POST: Schedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,When,Description,CoachEmail,Location")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            return View(schedule);
        }
        [Authorize(Policy = "Administrator")]
        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }
        [Authorize(Policy = "Administrator")]
        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET: Schedules/Enrol
        
        public async Task<IActionResult> Enrol(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }
        // POST: Schedules/Enrol/5
        [HttpPost, ActionName("Enrol")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrolConfirmed([Bind("Id,When,Description,CoachEmail,Location")] Schedule schedule)
        {
            var member = _userManager.GetUserName(User);

            
            
            ScheduleMembers schedulemembers = new ScheduleMembers { MemberEmail = member, ScheduleId = schedule.Id };
            _context.Update(schedulemembers);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [Authorize(Policy = "Coach")]
        // GET: Schedules/mySchedule
        [Authorize]
        public ActionResult MySchedule()
        {

            var coach = _userManager.GetUserName(User);

            var schedule = _context.Schedule
                .Where(m => m.CoachEmail == coach);
                
            return View("MySchedule", schedule);
        }



        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }
    }
}
