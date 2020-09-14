﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectSem3_merged.Models
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "EndDate is required.....")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Description is required.....")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        public string StaffId { get; set; }
        public string CompetitionImages { get; set; }
        public ICollection<Posting> Posting { get; set; }
        public ICollection<Award> Award { get; set; }
    }
}
