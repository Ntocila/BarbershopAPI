using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_Models.Models
{
    public class Service
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ServiceName { get; set; }

        [Required]
        public int ServiceDuration { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ServicePrice { get; set; }

        public List<Appointment> Appointments { get; set; }
    }
}
