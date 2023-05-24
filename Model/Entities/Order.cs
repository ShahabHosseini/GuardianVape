using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Order : EntityBase
{
    public string? Name { get; set; }

    public DateTime? Date { get; set; }

    public int? CustomerId { get; set; }

    public string? Channel { get; set; }

    public decimal? Total { get; set; }

    public int? PaymentStatusId { get; set; }

    public int? FulfillmentStatusId { get; set; }

    public int? Items { get; set; }

    public int? DeliveryMethodId { get; set; }

    public int? OrderProductId { get; set; }

    public int? ShippingAddress { get; set; }

    public int? BillingAddress { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual OrderProduct? OrderProduct { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
