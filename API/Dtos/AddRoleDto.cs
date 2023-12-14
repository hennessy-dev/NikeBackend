using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class AddRoleDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Role { get; set; }
}
