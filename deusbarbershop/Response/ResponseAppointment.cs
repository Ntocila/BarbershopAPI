using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deusbarbershop.Response
{
    /// <summary>
    /// Response after requesting details
    /// </summary>
    public class ResponseAppointment
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AppointmentDate{ get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ServiceName { get; set; }

    }
}
