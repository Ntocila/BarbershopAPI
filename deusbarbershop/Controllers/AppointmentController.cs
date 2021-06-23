using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Deus_DataAccessLayer.Data;
using Deus_Models.Models;
using deusbarbershop.Request;

namespace deusbarbershop.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments()
        {
            return await _context.Appointments.
                Include(customer => customer.Customer).
                Include(service => service.Service).
                ToListAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param ></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetAppointment(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);

            if (appointment == null)
            {
                return NotFound();
            }

            return appointment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param></param>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost("ChangeAppointment")]
        public async Task<IActionResult> PutAppointment(RequestAppointmentDetails appointment)
        {

            var result = await _context.Appointments.FindAsync(appointment.ID);

            if (result != null)
            {
                result.AppointmentDate = appointment.Date;
                await _context.SaveChangesAsync();

                return Ok("Appointment Succesfully Updated! ");
            }

            return BadRequest("Something went wrong retry later!");
          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Appointment>> PostAppointment(RequestAppointmentDetails requestAppointment)
        {
            DateTime now = DateTime.Now;
            if (now >= requestAppointment.Date)
            { throw new ArgumentException("Η ημερα που επελεξες ειναι παλια. Παρακαλω επελεξε σωστα την ημερα και δοκιμασε ξανα."); }
            else
            {
                Appointment appointment = new()
                {
                    AppointmentDate = requestAppointment.Date,
                    Customer = requestAppointment.Customer,
                    Service_Id = requestAppointment.Service_Id
                };
               
                _context.Appointments.Add(appointment);
                await _context.SaveChangesAsync();
                return Ok();
            }
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
