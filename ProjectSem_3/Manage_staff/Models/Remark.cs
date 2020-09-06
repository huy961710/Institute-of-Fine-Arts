using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Manage_staff.Models
{
    public class Remark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StaffId { get; set; }
        [Required]
        public string PostingId { get; set; }
    }
}
