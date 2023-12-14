using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class User : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    public ICollection<UserRol> UserRols { get; set; }
    public ICollection<Rol> Rols { get; set; } = new List<Rol>();
}
