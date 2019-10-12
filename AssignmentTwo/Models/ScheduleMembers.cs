using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentTwo.Models
{
    public partial class ScheduleMembers
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ScheduleID")]
        [Display(Name = "Schedule ID")]
        public int ScheduleId { get; set; }
        [Display(Name = "Member Email")]
        public string MemberEmail { get; set; }

        [Display(Name = "Coach Email")]
        public string CoachEmail { get; set; }
    }
}
