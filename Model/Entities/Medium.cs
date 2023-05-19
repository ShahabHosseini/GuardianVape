using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Medium
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Url { get; set; }

    public byte[]? Value { get; set; }

    public int? ProductId { get; set; }

    public int? CollectionId { get; set; }

    public virtual Collection? Collection { get; set; }

    public virtual Product? Product { get; set; }
}
