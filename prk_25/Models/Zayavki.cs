using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Zayavki
{
    public int IdApl { get; set; }

    public int IdPersonal { get; set; }

    public string DescС { get; set; } = null!;

    public virtual Personal IdPersonalNavigation { get; set; } = null!;
}
