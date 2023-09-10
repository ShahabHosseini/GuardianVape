using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Validators
{
    public interface IFileValidator
    {
        Task<string> ImageExist(string name,string url, long? Length);

    }
}
