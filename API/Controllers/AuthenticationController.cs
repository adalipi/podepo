using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthenticationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<string> Login(SignInRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            var useri = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, false, true);
            return useri.IsLockedOut ? "LOCKOUT" : useri.Succeeded ? "SUCCESS" : "WRONG";
        }
    }
}
