using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class CategoryGroup
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
