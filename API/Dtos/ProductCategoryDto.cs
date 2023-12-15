using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace API.Dtos
{
    public class ProductCategoryDto : BaseEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }
    }
}