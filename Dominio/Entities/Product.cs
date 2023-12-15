using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class Product : BaseEntity
{
     


    public string Title { get; set; } = null!;

    public string Image { get; set; } = null!;

    public double Price { get; set; }

    public string Descriptions { get; set; } = null!;

    public int Stock { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    public virtual ICollection<ProductOption> ProductOptions { get; set; } = new List<ProductOption>();

}
