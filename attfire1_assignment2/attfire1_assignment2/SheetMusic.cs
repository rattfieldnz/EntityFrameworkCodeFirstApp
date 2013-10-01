using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class SheetMusic
    {
        [Key]
        public int SheetMusicId { get; set; } 
        public string Title { get; set; } 
        public string ComposerName { get; set; } 
        public string DifficultyLevel { get; set; } 
        public short NumberOfAuthCopies { get; set; } 
        public string ScoreType { get; set; } 

        // Reverse navigation
        public virtual ICollection<PerformanceSheetMusic> PerformanceSheetMusic { get; set; } 
        public virtual ICollection<PersonSheetMusic> PersonSheetMusic { get; set; } 

        public SheetMusic()
        {
            PerformanceSheetMusic = new List<PerformanceSheetMusic>();
            PersonSheetMusic = new List<PersonSheetMusic>();
        }
    }
}
