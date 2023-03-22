using ProjectManagementApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagementApp.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.Username = "admin";
            u.Tasks = new List<string> { "Task1", "Task2" , "Task3", "Task4", "Task5"};
            u.Projects = new List<string> { "Project 1", "Project 2", "Project3", "Project4", "Project5" };


            return View(u);
        }
        public ActionResult Tasks()
        {
            UserData u = new UserData();
            u.Username = "admin";

            u.Tasks = new List<string> { "Task1", "Task2", "Task3", "Task4", "Task5" };
            u.Projects = new List<string> { "Project 1", "Project 2", "Project3", "Project4", "Project5" };


            return View(u);
        }
        public ActionResult Projects()
        {
            UserData u = new UserData();
            u.Username = "admin";

            u.Tasks = new List<string> { "Task1", "Task2", "Task3", "Task4", "Task5" };
            u.Projects = new List<string> { "Project 1", "Project 2", "Project3", "Project4", "Project5" };


            return View(u);
        }
    }
}