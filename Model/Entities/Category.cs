﻿using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Title { get; set; }

    public int? CategoryGroupId { get; set; }

    public virtual CategoryGroup? CategoryGroup { get; set; }

    public virtual ICollection<ConditionRoleType> ConditionRoleTypes { get; set; } = new List<ConditionRoleType>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
