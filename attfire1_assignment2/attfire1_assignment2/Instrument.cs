using System;
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
        [Key]
        public int InstrumentId { get; set; } 
        public string InstrumentName { get; set; } 
        public decimal HireFee { get; set; } 
        public string Condition { get; set; } 
        public string RepairStatus { get; set; } 

        // Reverse navigation
        public virtual ICollection<Student> Student { get; set; } 

        public Instrument()
        {
            Student = new List<Student>();
        }
    }
}
