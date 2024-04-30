using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class MaterialOrder
{
    public int IdOrder { get; set; }

    public int IdMat { get; set; }

    public string Value { get; set; } = null!;

    public virtual Material IdMatNavigation { get; set; } = null!;

    public virtual Order IdOrderNavigation { get; set; } = null!;
}
