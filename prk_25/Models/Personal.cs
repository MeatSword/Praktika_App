using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Personal
{
    public int IdPersonal { get; set; }

    public int RoleId { get; set; }

    public int OtdelId { get; set; }

    public string Name { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Sname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual PersonalUserDatum IdPersonalNavigation { get; set; } = null!;

    public virtual Otdel Otdel { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Zayavki> Zayavkis { get; set; } = new List<Zayavki>();
}
