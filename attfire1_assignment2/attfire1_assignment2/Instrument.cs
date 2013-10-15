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
        [Required]
        [Key]
        public int InstrumentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string InstrumentName { get; set; }
        [Required]
        public decimal HireFee { get; set; }
        [Required]
        public string RepairStatus { get; set; }
        [Required]
        public string ConditionStatus { get; set; }


        public Instrument()
        {
            
        }
    }
}
