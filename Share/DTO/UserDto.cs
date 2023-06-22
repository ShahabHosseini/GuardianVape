using Share.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class UserDto :BaseDto
    {
        public string FristName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string? Token { get; set; } = string.Empty;
        public string? RefreshToken { get; set; } = string.Empty;

        public DateTime RefreshTokenExpiryTime { get; set; }
        public string? ResetPasswordToken { get; set; } = string.Empty;
        public DateTime ResetPasswordExpiry { get; set; }

    }
}
