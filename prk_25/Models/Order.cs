using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prk_25.Models;

public partial class Order
{
    
    public int IdOrder { get; set; }
    [Required]
    [Range(1, 100000)]
    public int OtdelId { get; set; }
    [Required]
    [Range(1, 100000)]
    public int ProccesId { get; set; }
    [Required]
    [Range(1, 100000)]
    public int PartnerId { get; set; }
    [Required]
    public DateOnly Date { get; set; }
    [Required]
    public bool Status { get; set; }

    public virtual ICollection<MaterialOrder> MaterialOrders { get; set; } = new List<MaterialOrder>();

    public virtual Otdel Otdel { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;

    public virtual Proccese Procces { get; set; } = null!;
}
