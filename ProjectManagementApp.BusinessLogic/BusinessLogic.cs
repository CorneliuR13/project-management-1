﻿using ProjectManagementApp.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBl()
        {
            return new SessionBL();
        }
    }
}
