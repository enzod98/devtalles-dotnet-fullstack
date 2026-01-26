using System;
using System.ComponentModel.DataAnnotations;

namespace TechNotes.Features.Users;

public class RegisterUserModel
{
    [Required(ErrorMessage = "Nombre de usuario requerido")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email requerido")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Contraseña requerida")]
    public string Password { get; set; } = string.Empty;    

    [Required(ErrorMessage = "Confirmación de contraseña requerida")]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
    public string ConfirmPassword { get; set; } = string.Empty;

}
