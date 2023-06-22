using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.DTO
{
    public class EmailDto
    {
        public string To { get; set; }
        public string Contetnt { get; set; }
        public string Subject { get; set; }
        public EmailDto(string to,string subject,string content)
        {
            Contetnt = content;
            To = to;
            Subject = subject;
        }
    }
}
