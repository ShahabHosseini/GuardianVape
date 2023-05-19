using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class SearchEnginListing
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? PageTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? Urlhandle { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
