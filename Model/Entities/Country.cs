using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Country : EntityBase
{
    public string? Title { get; set; }
    public int? Numcode { get; set; }
    public string Iso { get; set; }
    public string? Iso3 { get; set; }
    public string Phonecode { get; set; }
    public string Nicename { get; set; }


    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
