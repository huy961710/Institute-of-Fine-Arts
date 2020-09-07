using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_student.Models
{
    public class StudentLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "StudentId is required.....")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "AccId must be from 3 to 10 characters")]        
        public string StudentId { get; set; }
        [Required(ErrorMessage = "Password is required.....")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must be from 5 to 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
