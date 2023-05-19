using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Phone
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? AreaCode { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
