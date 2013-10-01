using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class Performance
    {
        [Key]
        public int PerformanceId { get; set; } 
        public string PerformanceName { get; set; } 
        public DateTime DateAndTime { get; set; } 
        public int? LocationLocationId { get; set; } 

        // Reverse navigation
        public virtual ICollection<PerformanceSheetMusic> PerformanceSheetMusic { get; set; } 

        // Foreign keys
        [ForeignKey("LocationLocationId")]
        public virtual Location Location { get; set; } 

        public Performance()
        {
            PerformanceSheetMusic = new List<PerformanceSheetMusic>();
        }
    }
}
