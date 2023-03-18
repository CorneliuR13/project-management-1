using ProjectManagementApp.BusinessLogic.Core;
using ProjectManagementApp.BusinessLogic.Interfaces;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementApp.Domain.Entities.User;

namespace ProjectManagementApp.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public string GetCookies(ULoginData loginData)
        {
            return UserAsignCookies(loginData);
        }

        public bool ValidateCookies(string cookies)
        {
            return UserCookiesValidator(cookies);
        }
    }
}
