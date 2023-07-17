using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class FileDto
    {
        public string FileName { get; set; } = string.Empty;
        public byte[] Content { get; set; }
    }
}
