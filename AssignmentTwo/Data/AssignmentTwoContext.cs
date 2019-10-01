using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentTwo.Models;

namespace AssignmentTwo.Models
{
    public class AssignmentTwoContext : DbContext
    {
        public AssignmentTwoContext (DbContextOptions<AssignmentTwoContext> options)
            : base(options)
        {
        }

        public DbSet<AssignmentTwo.Models.Coach> Coach { get; set; }

        public DbSet<AssignmentTwo.Models.Schedule> Schedule { get; set; }

        public DbSet<AssignmentTwo.Models.ScheduleMembers> ScheduleMembers { get; set; }
    }
}
