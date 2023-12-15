using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public partial class ProductOption : BaseEntity
{

    public int ProductId { get; set; }

    public int OptionsId { get; set; }

    public virtual Option Options { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
