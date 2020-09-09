using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_posting.Models
{
    public class PostingStaffDesignCompetition
    {
        public Posting Posting { get; set; }
        public Design Design { get; set; }
        public Competition Competition { get; set; }
        public Staff Staff { get; set; }
    }
}
