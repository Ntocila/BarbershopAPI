using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_Models.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public int Customer_Id { get; set; }
        [Required]
        public int Service_Id { get; set; }
    }
}
