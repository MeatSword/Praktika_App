using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class TypeMaterial
{
    public int IdType { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
