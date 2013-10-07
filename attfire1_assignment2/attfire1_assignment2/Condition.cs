using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    class Condition
    {
        [Required]
        [Key]
        public int ConditionId { get; set; }
        [Required]
        public string ConditionName { get; set; }
        [Required]
        public string ConditionDescription { get; set; }
    }
}
