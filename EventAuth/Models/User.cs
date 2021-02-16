using System;
using System.ComponentModel.DataAnnotations;

namespace EventAuth.Models
{
    public class User
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }

        public string Email { get; set; }
        
        public int PhoneNumber { get; set; }
    }
}
