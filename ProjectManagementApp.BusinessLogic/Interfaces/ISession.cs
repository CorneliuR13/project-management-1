﻿using ProjectManagementApp.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.BusinessLogic.Interfaces
{
    public interface ISession
    {
        string GetCookies(ULoginData loginData);
        bool ValidateCookies(string cookies);
    }
}
