using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_Models.Models
{
    
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Customer> customers { get; set; }

        [ForeignKey("Service")]
        [Required]
        public int Service_Id { get; set; }
        public Service Service { get; set; }
        public ICollection<Service> services { get; set; }
    }
}
