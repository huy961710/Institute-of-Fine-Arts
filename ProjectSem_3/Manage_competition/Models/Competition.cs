using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_competition.Models
{
    [Table("Competition")]
    public class Competition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompetitionId { get; set; }
        [Required(ErrorMessage = "CompetitionName is required.....")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "CompetitionName must be from 3 to 50 characters")]
        public string CompetitionName { get; set; }
        [Required(ErrorMessage = "StartDate is required.....")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "EndDate is required.....")]
        public DateTime EndDate { get; set; }
        [Required]
        public string StaffId { get; set; }
    }
}
