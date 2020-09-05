using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_Staff.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "StaffId is required.....")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "StaffId must be from 3 to 10 characters")]
        public string StaffId { get; set; }
        [Required(ErrorMessage = "StaffName is required.....")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "StaffName must be from 3 to 50 characters")]
        public string StaffName { get; set; }
        [Required(ErrorMessage = "JoinDate is required.....")]
        public DateTime JoinDate { get; set; }
        [Required(ErrorMessage = "Email is required.....")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required.....")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Phone must be from 10 to 20 characters")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address is required.....")]
        public string Address { get; set; }
        [Required]
        public string AdminId { get; set; }
        [Required]
        public string AccId { get; set; }
    }
}
