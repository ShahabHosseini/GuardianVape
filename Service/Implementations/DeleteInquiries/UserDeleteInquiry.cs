using Service.Contracts.Inquiry;
using Service.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations.Inquiry
{
    public class UserDeleteInquiry : IUserDeleteInquiry
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public UserDeleteInquiry(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

    }
}
