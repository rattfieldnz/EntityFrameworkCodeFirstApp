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
        public int RepairStatusId { get; set; }
        [Required]
        public int ConditionId { get; set; }

        // Foreign keys
        [Required]
        [ForeignKey("ConditionId")]
        public virtual Condition InstrumentCondition { get; set; }

        [Required]
        [ForeignKey("RepairStatusId")]
        public virtual RepairStatus RepairStatus { get; set; }



        public Instrument()
        {
            InstrumentCondition = new Condition();
        }
    }
}
