using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class RefreshToken : BaseEntity
{
     


    public int UserId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime Expires { get; set; }

    public DateTime Created { get; set; }

    public bool IsActive { get; set; }

    public string Revoked { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
