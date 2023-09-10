using Share.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class CountryDto : DtoBase
    {
        public string? Title { get; set; }
        public int? Numcode { get; set; }
        public string Iso { get; set; }
        public string? Iso3 { get; set; }
        public string Phonecode { get; set; }
        public string Nicename { get; set; }
    }
}
