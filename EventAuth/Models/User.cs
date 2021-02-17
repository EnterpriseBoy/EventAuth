using System;
using System.ComponentModel.DataAnnotations;

namespace EventAuth.Models
{
    public class User
    {
        public Guid Id { get; set; }       
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Confirmed { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LogonTime { get; set; }

    }
}
