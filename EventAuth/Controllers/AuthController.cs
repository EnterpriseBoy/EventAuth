using EventAuth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace EventAuth.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthRepository _userRepo;

        public AuthController(ILogger<AuthController> logger, IAuthRepository userRepository)
        {
            _logger = logger;
            _userRepo = userRepository;
        }

        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            try
            {
                _logger.LogError("email:{email}, Password: {password}",email,password);
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
