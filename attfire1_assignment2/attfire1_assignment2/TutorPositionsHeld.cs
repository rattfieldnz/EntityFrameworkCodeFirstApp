using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class TutorPositionsHeld
    {
        [Key, Column(Order = 1)]
        public int PositionsHeldPositionId { get; set; }
        [Key, Column(Order = 2)]
        public int TutorTutorId { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("PositionsHeldPositionId")]
        public virtual PositionsHeld PositionsHeld { get; set; }
        [Required]
        [ForeignKey("TutorTutorId")]
        public virtual Tutor Tutor { get; set; } 
    }
}
