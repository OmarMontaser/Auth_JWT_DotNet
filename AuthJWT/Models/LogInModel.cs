﻿using System.ComponentModel.DataAnnotations;

namespace AuthJWT.Models
{
    public class LogInModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
