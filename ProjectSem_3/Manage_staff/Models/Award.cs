using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_staff.Models
{
    public class Award
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AwardId { get; set; }
        [Required]
        public string AwardName { get; set; }
        [Required]
        public string CompetitionId { get; set; }
        [Required]
        public int PostingId { get; set; }
        [Required]
        public string StaffId { get; set; }
    }
}
