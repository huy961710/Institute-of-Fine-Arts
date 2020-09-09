using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_award.Models
{
    public class AwardStaffCompetitionPosting
    {
        public Award Award { get; set; }
        public Competition Competition { get; set; }
        public Posting Posting { get; set; }
        public Staff Staff { get; set; }
    }
}
