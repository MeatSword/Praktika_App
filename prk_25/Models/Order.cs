using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public int OtdelId { get; set; }

    public int ProccesId { get; set; }

    public int PartnerId { get; set; }

    public DateOnly Date { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<MaterialOrder> MaterialOrders { get; set; } = new List<MaterialOrder>();

    public virtual Otdel Otdel { get; set; } = null!;

    public virtual Partner Partner { get; set; } = null!;

    public virtual Proccese Procces { get; set; } = null!;
}
