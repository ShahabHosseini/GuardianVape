using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;
public partial class Collection : EntityBase
{
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? ParentId { get; set; }

    public string? PageTitle { get; set; }

    public string? MetaDescription { get; set; }

    public byte[]? Media { get; set; }

    public virtual ICollection<ConditionRoleType> ConditionRoleTypes { get; set; } = new List<ConditionRoleType>();

    public virtual ICollection<Collection> InverseParent { get; set; } = new List<Collection>();

    public virtual ICollection<Medium> MediaNavigation { get; set; } = new List<Medium>();

    public virtual Collection? Parent { get; set; }

    public virtual ICollection<ProductCollection> ProductCollections { get; set; } = new List<ProductCollection>();
}
