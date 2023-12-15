using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class Rol : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<UserRol> UserRols { get; set; }
}
