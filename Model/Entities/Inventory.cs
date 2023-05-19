using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Inventory
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Sku { get; set; }

    public string? Barcode { get; set; }

    public int? ShopLocationId { get; set; }

    public bool? TrackQuantity { get; set; }

    public bool? ContinueSellingOutOfStock { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<ShopLocation> ShopLocations { get; set; } = new List<ShopLocation>();
}
