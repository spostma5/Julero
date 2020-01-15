using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julero.Models
{
    public class Tasks
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
