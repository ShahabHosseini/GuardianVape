using Microsoft.AspNetCore.Http;
using Share.DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class ImageDto 
    {
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;
        public string Guid { get; set; } = string.Empty;
        public DateTime UploadDate { get; set; }
    }
}
