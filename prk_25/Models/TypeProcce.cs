using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class TypeProcce
{
    public int IdType { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Proccese> Procceses { get; set; } = new List<Proccese>();
}
