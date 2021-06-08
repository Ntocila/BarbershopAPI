using AutoMapper;
using Deus_DataAccessLayer.IRepositories;
using Deus_Models.DTOs;
using Deus_Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deusbarbershop.Controllers
{

    /// <summary>
    /// Endpoint used to interact with the Customers in Barber Shop Database
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerRepository"></param>
        /// <param name="mapper"></param>
        public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns>List of Customers</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var customers = await _customerRepository.GetAll();
                return Ok(customers);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please contact the Administrator"); // Internal Service Error
            }

        }
        /// <summary>
        /// Get Customer By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Customer record</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
                var customer = await _customerRepository.GetById(id);
                if (customer == null)
                {
                    return NotFound();
                }
                return Ok(customer);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please contact the Administrator");
            }

        }
        /// <summary>
        /// Create or update a customer
        /// </summary>
        /// <param name="customerDTO"></param>
        /// <returns>Customer Info</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUpdate([FromBody] CustomerDto customerDTO)
        {
            try
            {
                if (customerDTO == null)
                {
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var customer = _mapper.Map<Customer>(customerDTO);
                var response = await _customerRepository.CreateUpdate(customer);
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
        /// Delete a customer record
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
                var customer = await _customerRepository.GetById(id);
                if (customer == null)
                {
                    return NotFound();
                }
                var isSuccess = await _customerRepository.Delete(customer);
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
