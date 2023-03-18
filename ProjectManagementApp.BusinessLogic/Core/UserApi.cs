using ProjectManagementApp.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.BusinessLogic.Core
{
    public class UserApi
    {
        public string UserAsignCookies(ULoginData loginData)
        {
            return "cookies";
        }

        public bool UserCookiesValidator(string cookies)
        {
            return true;
        }

    }
}
