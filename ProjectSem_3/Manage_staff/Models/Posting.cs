using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_staff.Models
{
    public class Posting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostingId { get; set; }
        [Required]
        public DateTime PostDate { get; set; }
        [Required]
        public string PostDescription { get; set; }
        [Required]
        public string Mark { get; set; }
        [Required]
        public string Remark { get; set; }
        [Required]
        public int DesignID { get; set; }
        [Required]
        public int CompetitionId { get; set; }
        [Required]
        public string StaffId { get; set; }
    }
}
