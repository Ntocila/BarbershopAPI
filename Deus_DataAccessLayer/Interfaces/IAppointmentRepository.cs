using Deus_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_DataAccessLayer.IRepositories
{
    public interface IAppointmentRepository : IBaseRepository<Appointment>
    {
        Task<bool> IsDateTimeAvailable(DateTime dateTime);
    }
}
