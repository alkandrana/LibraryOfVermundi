using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models.ViewModels;

public class LoginVM
{
    [Required(ErrorMessage = "Please enter a username.")]
    [StringLength(50)]
    public string Username { get; set; }
    [Required(ErrorMessage = "Please enter a password.")]
    [StringLength(50)]
    
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
    public bool RememberMe { get; set; }
    
}