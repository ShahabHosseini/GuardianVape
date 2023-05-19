using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Unit
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
