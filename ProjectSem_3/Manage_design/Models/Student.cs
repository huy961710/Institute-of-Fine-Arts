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
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }      
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string Address { get; set; }
        public string ProfileImage { get; set; }        
    }
}
