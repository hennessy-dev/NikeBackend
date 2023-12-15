using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace API.Dtos
{
    public class OptionDto : BaseEntity
    {
        public string OptionName { get; set; }

        public string OptionType { get; set; }
    }
}