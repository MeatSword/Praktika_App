using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Proccese
{
    public int IdProcces { get; set; }

    public int TypeId { get; set; }

    public string Name { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Volume { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual TypeProcce Type { get; set; } = null!;

    public virtual ICollection<Oborud> IdOboruds { get; set; } = new List<Oborud>();
}
