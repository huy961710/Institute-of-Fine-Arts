using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_account.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "AccId is required.....")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "AccId must be from 3 to 25 characters")]
        public string AccId { get; set; }
        [Required(ErrorMessage = "AccPass is required.....")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "AccPass must be from 3 to 50 characters")]
        [DataType(DataType.Password)]
        public string AccPass { get; set; }
        [Required(ErrorMessage = "Role is required.....")]
        [Range(0, 3, ErrorMessage = "Role must be from 0 to 3")]
        public int AccRole { get; set; }
        public bool Active { get; set; }
    }
}
