using Service.Contracts.DeleteInquiries;
using Service.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations.DeleteInquiries
{
    public class CollectionDeleteInquiry : ICollectionDeleteInquiry
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public CollectionDeleteInquiry(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<bool> DeleteInquiryAsync(int id)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                try
                {
                    //TODO think about that. you have to do some thing before delete directly
                    var res = await unitOfWork.Collection.GetAsync(id);
                    await unitOfWork.Collection.DeleteAsync(res);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
