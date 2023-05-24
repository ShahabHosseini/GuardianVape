using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Unit : EntityBase
{
    public string? Title { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
