using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class Image : EntityBase
{
    public string Url { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Alt { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Caption { get; set; } = string.Empty;
    public DateTime UploadDate { get; set; }
    public int? ProductId { get; set; }
    public virtual Product? Product { get; set; }
}
