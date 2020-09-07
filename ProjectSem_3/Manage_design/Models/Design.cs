using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//step 1
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace Manage_design.Models
{
    [Table("Design")]
    public class Design
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DesignId { get; set; }
        [Required]
        public string DesignName { get; set; }
        [Required]
        public string Painting { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime SubmitDate { get; set; }
        [Required]
        public string StudentId {get;set;}
    }
}
