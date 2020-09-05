using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_administrator.Models
{
    [Table("Administrator")]
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "AdminId is required.....")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "AdminId must be from 3 to 10 characters")]
        public string AdminId { get; set; }
        [Required(ErrorMessage = "AdminName is required.....")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "AdminName must be from 5 to 50 characters")]
        public string AdminName { get; set; }
        [Required]
        public string AccId { get; set; }
    }
}
