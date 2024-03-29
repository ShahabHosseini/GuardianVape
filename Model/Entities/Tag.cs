﻿using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Tag
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public int? ParentId { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<ConditionRoleType> ConditionRoleTypes { get; set; } = new List<ConditionRoleType>();

    public virtual ICollection<Tag> InverseParent { get; set; } = new List<Tag>();

    public virtual Tag? Parent { get; set; }

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
}
