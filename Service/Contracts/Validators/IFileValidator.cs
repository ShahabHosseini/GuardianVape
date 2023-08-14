using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Validators
{
    public interface IFileValidator
    {
        Task<string> NameExist(string name,string url, long? Length);

    }
}
