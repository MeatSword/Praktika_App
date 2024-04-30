using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Otdel
{
    public int IdOtdel { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
