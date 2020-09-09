using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_award.Models
{
    [Table("Posting")]
    public class Posting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostingId { get; set; }
        [Required]
        public DateTime PostDate { get; set; }
        public string PostDescription { get; set; }
        public string Mark { get; set; }
        public string Remark { get; set; }
        [Required]
        public int DesignId { get; set; }
        [Required]
        public int CompetitionId { get; set; }
        public string StaffId { get; set; }

        public ICollection<Award> Award { get; set; }
    }
}
