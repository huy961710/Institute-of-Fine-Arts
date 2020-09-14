using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//step 1
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace Manage_design.Models
{
    [Table("Posting")]
    public class Posting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostingId { get; set; }
        [Required(ErrorMessage = "PostDate is required.")]
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public string PostDescription { get; set; }
        public string Mark { get; set; }
        public string Remark { get; set; }        
        [ForeignKey("DesignID")]
        public int DesignID { get; set; }        
        [ForeignKey("CompetitionId")]
        public int CompetitionId { get; set; }
        [ForeignKey("StaffId")]
        public string StaffId { get; set; }
    }
}
