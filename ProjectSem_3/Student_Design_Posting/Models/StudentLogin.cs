using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Student_Design_Posting.Models
{
    public class StudentLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "StudentId is required.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "StudentId must be from 3 to 10 characters")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must be from 5 to 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
