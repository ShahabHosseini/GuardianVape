using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class GvImage :EntityBase
    {
        public string FileName { get; set; }=string.Empty;
        public string Path { get; set; } = string.Empty;
        public string ImageType { get; set;} = string.Empty;
    }
}
