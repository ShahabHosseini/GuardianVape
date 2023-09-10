using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.DeleteInquiries
{
    public interface ICollectionDeleteInquiry
    {
        Task<bool> DeleteInquiryAsync(int id);
    }
}
