using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_Models.Models
{
   public class Customer
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        
        [EmailAddress]
        [MaxLength(250)]
        public string EmailAddress { get; set; }
    }
}
