using System.ComponentModel.DataAnnotations;

namespace Bloggie.Models
{
  public class User
  {
    public int Id { get; set; }
    [DataType(DataType.EmailAddress)]
    [Required]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; }
    public string FullName { get; set; }
    public bool Active { get; set; }=true;
    public UserRole Role { get; set; }
  }

  public enum UserRole
  {
    Writer,//Role mặc định là writer
    Moderator,
    Admin
  }
}