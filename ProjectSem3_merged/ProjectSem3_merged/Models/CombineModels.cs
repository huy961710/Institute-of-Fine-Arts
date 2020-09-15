using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSem3_merged.Models
{
    public class CombineModels
    {
        public Competition Competition { get; set; }
        public Design Design { get; set; }
        public Posting Posting { get; set; }
        public Staff Staff { get; set; }
        public Student Student { get; set; }
        public Award Award { get; set; }
        public Exhibition Exhibition { get; set; }
        public Display Display { get; set; }
    }
}
