using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? FristName { get; set; }

    public string? LastName { get; set; }

    public string? Language { get; set; }

    public string? Email { get; set; }

    public int? PhoneId { get; set; }

    public bool? AgreedEmail { get; set; }

    public bool? AgreedSms { get; set; }

    public int? AddressId { get; set; }

    public string? Note { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Phone? Phone { get; set; }

    public virtual ICollection<RelatedTag> RelatedTags { get; set; } = new List<RelatedTag>();

    public virtual ICollection<TimeLine> TimeLines { get; set; } = new List<TimeLine>();
}
