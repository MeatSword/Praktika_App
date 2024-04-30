using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prk_25.Models;

public partial class Personal
{
    
    public int IdPersonal { get; set; }
    [Required]
    [Range(1, 100000)]
    public int RoleId { get; set; }
    [Required]
    [Range(1, 100000)]
    public int OtdelId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;
    [Required]
    [StringLength(50)]
    public string Lname { get; set; } = null!;
    [Required]
    [StringLength(50)]
    public string Sname { get; set; } = null!;
    [Required]
    [StringLength(50)]
    public string Phone { get; set; } = null!;

    public virtual PersonalUserDatum IdPersonalNavigation { get; set; } = null!;

    public virtual Otdel Otdel { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Zayavki> Zayavkis { get; set; } = new List<Zayavki>();
}
