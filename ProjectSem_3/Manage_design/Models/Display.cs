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
    [Table("Display")]
    public class Display
    {
        [Required]
        public decimal Price { get; set; }
        public bool SoldStatus { get; set; }
        public bool PaidStatus { get; set; }
        [Key]
        public int DesignId { get; set; }
        [Key]
        public int ExhibitionID { get; set; }
        public string CustomerName { get; set; }
    }
}
