using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentTwo.Models
{
    public partial class Schedule
    {
        [Display(Name = "Schedule ID")]
        [Column("ID")]
        public int Id { get; set; }
        public DateTime When { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Coach Email")]
        public string CoachEmail { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
