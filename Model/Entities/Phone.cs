using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Phone : EntityBase
{
    public string? AreaCode { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
