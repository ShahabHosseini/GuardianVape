using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class RelatedTag : EntityBase
{
    public int? ProductId { get; set; }

    public int? CostumerId { get; set; }

    public virtual Customer? Costumer { get; set; }

    public virtual Product? Product { get; set; }
}
