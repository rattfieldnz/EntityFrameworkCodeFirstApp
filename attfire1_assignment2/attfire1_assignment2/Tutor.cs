using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Tutor
    {
        [Key]
        public int TutorId { get; set; } 
        public int PersonPersonId { get; set; } 

        // Reverse navigation
        public virtual ICollection<Lesson> Lesson { get; set; } 
        public virtual ICollection<TutorPositionsHeld> TutorPositionsHeld { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("PersonPersonId")]
        public virtual Person Person { get; set; } 

        public Tutor()
        {
            Lesson = new List<Lesson>();
            TutorPositionsHeld = new List<TutorPositionsHeld>();
        }
    }
}
