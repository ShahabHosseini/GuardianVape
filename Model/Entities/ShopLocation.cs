﻿using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class ShopLocation
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public int? Committed { get; set; }

    public int? Available { get; set; }

    public int? OnHand { get; set; }

    public int? InventoryId { get; set; }

    public virtual Inventory? Inventory { get; set; }
}
