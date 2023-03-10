using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagementApp.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        public List<String> Projects { get; set; }
        public List<String> Tasks { get; set; }
    }
}