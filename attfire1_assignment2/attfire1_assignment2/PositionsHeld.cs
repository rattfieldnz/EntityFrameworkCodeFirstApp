using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class PositionsHeld
    {
        [Required]
        [Key]
        public int PositionId { get; set; } 
        [Required]
        [MaxLength(35)]
        public string PositionName { get; set; } 

        // Reverse navigation
        public virtual ICollection<TutorPositionsHeld> TutorPositionsHeld { get; set; } 

        public PositionsHeld()
        {
            TutorPositionsHeld = new List<TutorPositionsHeld>();
        }
    }
}
