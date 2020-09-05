using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Manage_address.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "StreetAddress is required.....")]
        public string StreetAddress { get; set; }
        [Required(ErrorMessage = "Country is required.....")]
        public string Country { get; set; }
        [Required(ErrorMessage = "PostalCode is required.....")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "City is required.....")]
        public string City { get; set; }
    }
}
