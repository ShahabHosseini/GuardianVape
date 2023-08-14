using Service.Contracts.Repositories;
using Service.Contracts.Validation;
using Service.Contracts.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Implementations.Validators
{
    public class FileValidator : IFileValidator
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public FileValidator(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;

        }
        public async Task<string> NameExist(string name,string url,long? length)
        {
            StringBuilder sb = new StringBuilder();
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var image = await unitOfWork.File.FindAllAsync(x => x.Name == name && x.Url==url && x.Length==length);
                if (image.Count>=1) sb.AppendLine("this image already exist");
               
            }

            return sb.ToString();
        }


    }
}
