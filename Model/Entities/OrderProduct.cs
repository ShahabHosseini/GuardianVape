using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class OrderProduct
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Product? Product { get; set; }
}
