﻿using System.ComponentModel.DataAnnotations;

namespace Application.Login;

public class Login
{
    [Required(ErrorMessage = "User Name is required")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}
