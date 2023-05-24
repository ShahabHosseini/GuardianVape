using Model.Base;
using System;
using System.Collections.Generic;

namespace Model.Entities;

public partial class User : EntityBase
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FristName { get; set; } = string.Empty;
    public string LastName { get; set; }= string.Empty;
    public virtual ICollection<TimeLine> TimeLines { get; set; } = new List<TimeLine>();
}
