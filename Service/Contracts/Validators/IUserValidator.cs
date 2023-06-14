using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Validation
{
    public interface IUserValidator
    {
        Task<string> UserNameExist(string userName, string email, string password);

    }
}
