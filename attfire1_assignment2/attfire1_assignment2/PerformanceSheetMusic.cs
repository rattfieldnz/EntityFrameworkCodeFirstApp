using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class PerformanceSheetMusic
    {
        [Key, Column(Order = 1)]
        public int SheetMusicSheetMusicId { get; set; }

        [Key, Column(Order = 2)]
        public int PerformancePerformanceId { get; set; } 

        // Foreign keys
        
        [ForeignKey("SheetMusicSheetMusicId")]
        public virtual SheetMusic SheetMusic { get; set; }
        
        [ForeignKey("PerformancePerformanceId")]
        public virtual Performance Performance { get; set; } 
    }
}
