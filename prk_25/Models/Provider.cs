using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Provider
{
    public int IdProvider { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
