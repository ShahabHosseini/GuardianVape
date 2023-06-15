using Service.Contracts.Repositories;
using Service.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Implementations.Validation
{
    public class UserValidator:IUserValidator
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public UserValidator(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        public async Task<string> UserNameExist(string userName,string email,string password)
        {
            StringBuilder sb= new StringBuilder();
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var username = await unitOfWork.User.FindAsync(x => x.UserName == userName);
                if (username != null) sb.AppendLine("User Name Already Exist");
                var useremail = await unitOfWork.User.FindAsync(x => x.Email == email);
                if (useremail != null) sb.AppendLine("Email Already Exist");

                if (password.Length < 8)
                    sb.AppendLine("Minimum password lenght should be 8!");
                if (!(Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[0-9]")))
                    sb.AppendLine("Password should be Alphanumeric!");
                if (!(Regex.IsMatch(password, "[<,>,.,[,{,(,*,+,?,^,$,|,_,-]")))
                    sb.AppendLine("Password should be special chars!");

            }

            return sb.ToString();
        }
    }
}
