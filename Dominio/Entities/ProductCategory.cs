using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class ProductCategory : BaseEntity
{
     


    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
