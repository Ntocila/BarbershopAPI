using Deus_Models.DTOs;
using Deus_Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deusbarbershop.Controllers
{
    /// <summary>
    /// Endpoint used to interact with the ApplicationUser(IdentityUser) in Barber Shop Database
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {


        private readonly SignInManager<ApplicationOwner> _signInManager;
        private readonly UserManager<ApplicationOwner> _userManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signInManager"></param>
        /// <param name="userManager"></param>
        public OwnerController(SignInManager<ApplicationOwner> signInManager,
            UserManager<ApplicationOwner> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        /// <summary>
        /// User Login Endpoint
        /// </summary>
        /// <param name="loginDTO"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDTO)
        {
            try
            {
                var username = loginDTO.EmailAddress;
                var password = loginDTO.Password;
                // Attempt the authentication
                var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(username);
                    // I need a mapper userDTO 
                    return Ok(user);
                }
                return Unauthorized(loginDTO);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong. Please contact the Administrator");
            }
        }
    }
}
