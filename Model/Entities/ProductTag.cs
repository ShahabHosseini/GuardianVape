using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ProductTag : EntityBase
{
    public int? ProductId { get; set; }

    public int? TagId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Tag? Tag { get; set; }
}
