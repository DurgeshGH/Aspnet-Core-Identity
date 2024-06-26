﻿using System.ComponentModel.DataAnnotations;

namespace Aspnet_Core_Identity.ViewModels
{
    public class Register
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Password and ConfirmPassword did not match")]
        public string ConfirmPassword { get; set; }
    }
}
