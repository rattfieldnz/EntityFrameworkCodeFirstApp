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
        [Required]
        [Key]
        public int SheetMusicId { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title { get; set; }
        [Required]
        public string ComposerName { get; set; }
        [Required]
        [Range(0,8)]
        public short DifficultyLevel { get; set; }
        [Required]
        public short NumberOfAuthCopies { get; set; }
        [Required]
        public string ScoreType { get; set; } 

        // Reverse navigation
        public virtual ICollection<PerformanceSheetMusic> PerformanceSheetMusic { get; set; } 
        public virtual ICollection<StudentSheetMusic> PersonSheetMusic { get; set; } 

        public SheetMusic()
        {
            PerformanceSheetMusic = new List<PerformanceSheetMusic>();
            PersonSheetMusic = new List<StudentSheetMusic>();
        }
    }
}
