using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ProjectManagementApp.BusinessLogic;
using ProjectManagementApp.BusinessLogic.Interfaces;
using ProjectManagementApp.Domain.Entities.User;

namespace ProjectManagementApp.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private readonly ISession _sessionBL;
        public LoginController()
        {
            BusinessLogic.BusinessLogic bl = new BusinessLogic.BusinessLogic();
            _sessionBL = bl.GetSessionBl();
        }
        public ActionResult Index()
        {
            ULoginData loginData = new ULoginData();
            loginData.Credential = "test";
            loginData.Password = "password";
            loginData.LoginIp = "ip";
            loginData.LoginDateTime = DateTime.Now;
            string cookies = _sessionBL.GetCookies(loginData);

            if (_sessionBL.ValidateCookies(cookies))
            {

            }
            return View();
        }
    }
}