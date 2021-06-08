using AutoMapper;
using Deus_DataAccessLayer.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Deus_Models.DTOs;
using Deus_Models.Models;
using System;
using System.Threading.Tasks;

namespace deusbarbershop.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {/// <summary>
     /// Endpoint used to interact with the SalonServices in Barber Shop Database
     /// </summary>

        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceRepository"></param>
        /// <param name="mapper"></param>
        public ServiceController(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Salon Services
        /// </summary>
        /// <returns>List of the Salon Services</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetServices()
        {
            try
            {
                var services = await _serviceRepository.GetAll();
                return Ok(services);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please contact the Administrator"); // Internal Service Error
            }
        }

        /// <summary>
        /// Get Salon Service By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Salon Service record</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServiceById(int id)
        {
            try
            {
                var service = await _serviceRepository.GetById(id);
                if (service == null)
                {
                    return NotFound();
                }
                return Ok(service);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please contact the Administrator");
            }

        }
        /// <summary>
        /// Create or Update a salon service
        /// </summary>
        /// <param name="serviceDTO"></param>
        /// <returns>Salon Service Info</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUpdate([FromBody] ServiceDto serviceDTO)
        {

            try
            {
             
                if (serviceDTO == null)
                {
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
       
                var service = _mapper.Map<Service>(serviceDTO);
                var response = await _serviceRepository.CreateUpdate(service);
                if (response == null)
                {
                    return StatusCode(500, "Something went wrong. Please try again later!");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please try again later!");
            }

        }
        /// <summary>
        /// Delete a salon service record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest();
                }
                var service = await _serviceRepository.GetById(id);
                if (service == null)
                {
                    return NotFound();
                }
                var isSuccess = await _serviceRepository.Delete(service);
                if (!isSuccess)
                {
                    return StatusCode(500, "Something went wrong. Please try again later!");
                }
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please try again later!");
            }
        }
    }
}
