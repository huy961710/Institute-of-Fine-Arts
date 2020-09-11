using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//step 1
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace Student_Design_Posting.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]        
        public DateTime JoinDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ProfileImage { get; set; }
        //[Required]
        public int? CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public virtual Competition Competition { get; set; }
    }
}
