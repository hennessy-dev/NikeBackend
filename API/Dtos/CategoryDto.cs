using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace API.Dtos
{
    public class CategoryDto : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}