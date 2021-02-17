﻿using EventAuth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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

        [HttpGet]
        public ActionResult Login(string email,string password)
        {
            try
            {
                return Ok(_userRepo.Login(email, password));
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Exception: {ExceptionMessage}", ex.Message);
                return Unauthorized();
            }
        }

        [HttpPost]
        public ActionResult Register(string email, string password)
        {
            try
            {
                return Ok(_userRepo.Register(email, password));
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Exception: {ExceptionMessage}", ex.Message);
                return Unauthorized();
            }
        }

    }
}
