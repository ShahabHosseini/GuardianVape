using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Title { get; set; }

    public string? AreaCode { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
