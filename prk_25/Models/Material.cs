using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class Material
{
    public int IdMat { get; set; }

    public int TypeMatId { get; set; }

    public int ProviderId { get; set; }

    public float Dencity { get; set; }

    public int Price { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<MaterialOrder> MaterialOrders { get; set; } = new List<MaterialOrder>();

    public virtual Provider Provider { get; set; } = null!;

    public virtual TypeMaterial TypeMat { get; set; } = null!;
}
