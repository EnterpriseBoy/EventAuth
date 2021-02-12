using EventAuth.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EventAuth.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _userRepo;

        public AuthController(IAuthRepository userRepository)
        {
            _userRepo = userRepository;
        }

        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            try
            {
                _userRepo.Login(email, password);
            }
            catch (System.Exception)
            {
                return Unauthorized();
            }
            return Ok();
        }

    }
}
