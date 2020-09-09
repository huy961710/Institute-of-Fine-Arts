using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_exhibition.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string StaffId { get; set; }
        [Required]
        public string StaffName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }
        public string ProfileImage { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Role { get; set; }

        public ICollection<Exhibition> Exhibition { get; set; }
    }
}
