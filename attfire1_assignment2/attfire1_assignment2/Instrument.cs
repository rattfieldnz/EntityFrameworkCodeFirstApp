﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Instrument
    {
        [Required]
        [Key]
        public int InstrumentId { get; set; }
        [Required]
        public string InstrumentName { get; set; }
        [Required]
        public decimal HireFee { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string RepairStatus { get; set; } 

        // Reverse navigation
        public virtual ICollection<Student> Student { get; set; } 

        public Instrument()
        {
            Student = new List<Student>();
        }
    }
}
