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
        public string InstrumentName { get; set; }
        [Required]
        public decimal HireFee { get; set; }
        [Required]
        public string RepairStatus { get; set; }
        [Required]
        public int ConditionId { get; set; }

        // Foreign keys
        [Required]
        [ForeignKey("ConditionId")]
        public virtual Condition InstrumentCondition { get; set; }

        public Instrument()
        {
            InstrumentCondition = new Condition();
        }
    }
}
