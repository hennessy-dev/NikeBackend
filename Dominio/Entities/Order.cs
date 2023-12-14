using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class Order : BaseEntity
{
    public int CustomerId { get; set; }

    public int Ammount { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string OrderStatus { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public virtual User Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
