using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Partner
{
    public int IdPartner { get; set; }

    public int ManagerId { get; set; }

    public string Name { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Sname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual Personal Manager { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
