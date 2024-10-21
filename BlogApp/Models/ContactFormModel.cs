using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models;

public class ContactFormModel
{
    [Required(ErrorMessage = "Ad Soyad gereklidir.")]
    public string FullName { get; set; }
    [Required(ErrorMessage = "Email gereklidir.")]
    public string Email { get; set; } 
    [Required(ErrorMessage = "Subject gereklidir.")]  
    public string Subject { get; set; }
    [Required(ErrorMessage = "Message gereklidir.")]
    public string Message { get; set; }
}
