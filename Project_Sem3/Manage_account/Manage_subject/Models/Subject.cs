using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_subject.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "SubjectId is required.....")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "SubjectId must be from 3 to 10 characters")]
        public string SubjectId { get; set; }
        [Required(ErrorMessage = "SubjectName is required.....")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "SubjectName must be from 5 to 50 characters")]
        public string SubjectName { get; set; }
        [Required(ErrorMessage = "Description is required.....")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Description must be from 5 to 50 characters")]
        public string Description { get; set; }
        [Required]
        public string ClassId { get; set; }
    }
}
