using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Oborud
{
    public int IdOborud { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Proccese> IdProcs { get; set; } = new List<Proccese>();
}
