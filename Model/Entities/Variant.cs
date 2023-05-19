using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Variant
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Title { get; set; }

    public int? ColorId { get; set; }

    public byte[]? Image { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
