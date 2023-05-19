using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal? CompareatPrice { get; set; }

    public decimal? CostPerItem { get; set; }

    public bool TrackQuantity { get; set; }

    public int? ShopLocation { get; set; }

    public int UnitId { get; set; }

    public int? ProductTypeId { get; set; }

    public int VendorId { get; set; }

    public int CategoryId { get; set; }

    public bool? Active { get; set; }

    public int? SearchEnginListingId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Medium> Media { get; set; } = new List<Medium>();

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual ICollection<ProductCollection> ProductCollections { get; set; } = new List<ProductCollection>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    public virtual ProductType? ProductType { get; set; }

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();

    public virtual ICollection<RelatedTag> RelatedTags { get; set; } = new List<RelatedTag>();

    public virtual SearchEnginListing? SearchEnginListing { get; set; }

    public virtual Unit Unit { get; set; } = null!;

    public virtual Vendor Vendor { get; set; } = null!;
}
