using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Julero.Models
{
    public class Goal
    {
        public int ID { get; set; }
        public string name { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }
        public List<Tasks> tasks { get; set; }
    }
}
