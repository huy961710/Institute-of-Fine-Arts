using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_customer.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "CustomerName is required.....")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "CustomerName must be from 3 to 50 characters")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Phone is required.....")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Phone must be from 10 to 20 characters")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required.....")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "ClassName must be from 5 to 50 characters")]
        public string Email { get; set; }
    }
}
