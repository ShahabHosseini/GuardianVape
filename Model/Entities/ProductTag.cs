using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ProductTag
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public int? ProductId { get; set; }

    public int? TagId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Tag? Tag { get; set; }
}
