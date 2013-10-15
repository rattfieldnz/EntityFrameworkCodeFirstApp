using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class StudentSheetMusic
    {
        [Key, Column(Order = 1)]
        public int StudentStudentId { get; set; }
        [Key, Column(Order = 2)]
        public int SheetMusicSheetMusicId { get; set; } 

        // Foreign keys
        [ForeignKey("StudentStudentId")]
        public virtual Student Student { get; set; }
        [ForeignKey("SheetMusicSheetMusicId")]
        public virtual SheetMusic SheetMusic { get; set; } 
    }
}
