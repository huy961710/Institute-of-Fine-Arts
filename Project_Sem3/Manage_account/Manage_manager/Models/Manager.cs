using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_manager.Models
{
    [Table("Manager")]
    public class Manager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ManagerId is required.....")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "ManagerId must be from 3 to 10 characters")]
        public string ManagerId { get; set; }
        [Required(ErrorMessage = "ManagerName is required.....")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ManagerName must be from 3 to 50 characters")]
        public string ManagerName { get; set; }
        [Required]
        public string AccId { get; set; }
    }
}
