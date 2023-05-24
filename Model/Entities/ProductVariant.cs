using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ProductVariant : EntityBase
{
    public string? Value { get; set; }

    public int ProductId { get; set; }

    public int VariantId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Variant Variant { get; set; } = null!;
}
