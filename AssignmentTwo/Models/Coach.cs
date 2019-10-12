using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentTwo.Models
{
    public partial class Coach
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Biography { get; set; }
        [Column("PhotoURL")]
        public string PhotoUrl { get; set; }
    }
}
