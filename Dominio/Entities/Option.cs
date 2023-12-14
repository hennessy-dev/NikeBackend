using System;
using System.Collections.Generic;

namespace Dominio.Entities;


public partial class Option : BaseEntity
{
    public string OptionName { get; set; } = null!;

    public string OptionType { get; set; } = null!;
}
