using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO.Base
{
    public class BaseDto
    {
        public int Id { get; set; }
        [MaxLength(36)]
        public string GUID { get; set; } = string.Empty;
    }
}
