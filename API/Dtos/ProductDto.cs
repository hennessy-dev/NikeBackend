using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace API.Dtos
{
    public class ProductDto : BaseEntity
    {
        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;

        public double Price { get; set; }

        public string Descriptions { get; set; } = null!;

        public int Stock { get; set; }
    }
}