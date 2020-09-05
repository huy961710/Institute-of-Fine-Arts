using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_class.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ClassId is required.....")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "ClassId must be from 3 to 10 characters")]
        public string ClassId { get; set; }
        [Required(ErrorMessage = "ClassName is required.....")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "ClassName must be from 5 to 50 characters")]
        public string ClassName { get; set; }
    }
}
