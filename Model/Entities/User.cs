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
    public string Role { get; set; } = string.Empty;
    public string? Token { get; set; } = string.Empty;
    public string? RefreshToken { get; set; } = string.Empty;
    public DateTime RefreshTokenExpiryTime { get; set; }
    public string? ResetPasswordToken { get; set; } = string.Empty;
    public DateTime ResetPasswordExpiry { get; set; }
    public virtual ICollection<TimeLine> TimeLines { get; set; } = new List<TimeLine>();
}
