using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_Models.DTOs
{
   public class ServiceDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string ServiceName { get; set; }
   
        [Required]
        public int ServiceDuration { get; set; }
        [Required]
        public decimal ServicePrice { get; set; }
    }
}
