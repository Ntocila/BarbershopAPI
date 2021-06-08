using Deus_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deusbarbershop.Request
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestAppointmentDetails
    {
        /// <summary>
        /// retrieving ID to change the details of that appointment
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// retrieving date  to change the details of that appointment
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Id of specific Service
        /// </summary>
        public int Service_Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Customer Customer { get; set; }

    }
}
