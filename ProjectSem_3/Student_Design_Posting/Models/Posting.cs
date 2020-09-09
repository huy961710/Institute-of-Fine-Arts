using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//step 1
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace Student_Design_Posting.Models
{
    [Table("Posting")]
    public class Posting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int PostingId { get; set; }
        [Required]
        public DateTime PostDate { get; set; }
        public string PostDescription { get; set; }
        public string Mark { get; set; }
        public string Remark { get; set; }
        [Required]
        [ForeignKey("DesignID")]
        public int DesignID { get; set; }
        [Required]
        [ForeignKey("CompetitionId")]
        public int CompetitionId { get; set; }
        [Required]
        [ForeignKey("StaffId")]
        public string StaffId { get; set; }
    }
}
