using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Student
    {
        [Required]
        [Key]
        public int StudentId { get; set; } 
        [Required]
        public short Age { get; set; }
        [Required]
        public decimal LessonFeesOwed { get; set; }
        [Required]
        public decimal InstrumentFeesOwed { get; set; }
        public int? InstrumentInstrumentId { get; set; }
        [Required]
        public int PersonPersonId { get; set; } 
        [Required]
        public int ParentParentId { get; set; } 

        // Reverse navigation
        public virtual ICollection<StudentLesson> StudentLesson { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("PersonPersonId")]
        public virtual Person Person { get; set; }
        
        [ForeignKey("InstrumentInstrumentId")]
        public virtual Instrument Instrument { get; set; }
        [Required]
        [ForeignKey("ParentParentId")]
        public virtual Parent Parent { get; set; }

        public Student()
        {
            StudentLesson = new List<StudentLesson>();
        }
    }
}
