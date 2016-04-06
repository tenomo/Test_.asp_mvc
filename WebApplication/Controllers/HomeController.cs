using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {      

            return View();
        }

        public ActionResult Contact()
        { 

            return View();
        }


         [HttpGet]
        public ActionResult UserSubscriber()
        {

            return View();
        }

     public static   Models.UsersDate userData = new Models.UsersDate();

        // [HttpPost]
        //public ActionResult UserSubscriber(string firstName, string lastName, string email)
        //{
        //    ViewBag.Message = "input strings";
        //    userData.AddUser(firstName, lastName, email);
        //    return View();
        //}

        [HttpPost]
        public  ActionResult  UserSubscriber(Models.User user)
        {

            try {
                ViewBag.Message = "input user";
                userData.AddUser(user);
            }
            catch
            {

            }
            return View();
        }


        [HttpGet]
        public ActionResult ShowUsers()
        {

            return View();
        }
    }
}