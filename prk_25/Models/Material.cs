using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prk_25.Models;

public partial class Material
{
    
    public int IdMat { get; set; }
    [Required]
    [Range(1, 100000)]
    public int TypeMatId { get; set; }
    [Required]
    [Range(1, 100000)]
    public int ProviderId { get; set; }
    [Required]
    [Range(0.1, 100.1)]
    public float Dencity { get; set; }
    [Required]
    [Range(1, 100000)]
    public int Price { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public virtual ICollection<MaterialOrder> MaterialOrders { get; set; } = new List<MaterialOrder>();

    public virtual Provider Provider { get; set; } = null!;

    public virtual TypeMaterial TypeMat { get; set; } = null!;
}
