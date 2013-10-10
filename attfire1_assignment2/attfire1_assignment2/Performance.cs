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
        [Required]
        public int PerformanceId { get; set; }
        [Required]
        public string PerformanceName { get; set; } 
        [Required]
        public DateTime PerformanceDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime FinishTime { get; set; }
        [Required]
        public int? LocationLocationId { get; set; } 

        // Reverse navigation
        public virtual ICollection<PerformanceSheetMusic> PerformanceSheetMusic { get; set; } 

        // Foreign keys
        [Required]
        [ForeignKey("LocationLocationId")]
        public virtual Location Location { get; set; } 

        public Performance()
        {
            PerformanceSheetMusic = new List<PerformanceSheetMusic>();
        }
    }
}
