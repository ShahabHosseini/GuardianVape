using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;



public partial class CategoryGroup :EntityBase
{
    public string? Title { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
