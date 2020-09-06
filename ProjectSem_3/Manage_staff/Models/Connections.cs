using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_staff.Models
{
    public class Connections
    {
        public Staff Staff { get; set; }
        public Award Award { get; set; }
        public Exhibition Exhibition { get; set; }
        public Posting Posting { get; set; }
        public Remark Remark { get; set; }
        public Competition Competition { get; set; }
    }
}
