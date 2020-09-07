﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//step 1
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace Manage_student.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "StudentId is required.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "AccId must be from 3 to 10 characters")]
        public string StudentId { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must be from 5 to 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "FirstName must be from 3 to 50 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "LastName must be from 3 to 50 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "DateOfBirth is required.")]        
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Gender is required.")]      
        public string Gender { get; set; }
        [Required(ErrorMessage = "Phone is required.")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Phone must be from 10 to 20 characters")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }         
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Address must be from 5 to 255 characters")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string ProfileImage { get; set; }
        public int? CompetitionId { get; set; }
    }
}
