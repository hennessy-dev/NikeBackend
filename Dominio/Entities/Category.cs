using System;
using System.Collections.Generic;

namespace Dominio.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}
