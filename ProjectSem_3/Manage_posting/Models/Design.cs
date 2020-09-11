using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_posting.Models
{
    [Table("Design")]
    public class Design
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DesignId { get; set; }
        [Required]
        public string DesignName { get; set; }
        [Required]
        public string Painting { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
        [Required]
        public string StudentId { get; set; }

        public ICollection<Posting> Posting { get; set; }
    }
}
