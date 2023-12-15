using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace API.Dtos
{
    public class OrderDto : BaseEntity
    {
        public int CustomerId { get; set; }

        public int Ammount { get; set; }

        public string ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; }

        public string Comments { get; set; }

    }
}