using Bucket.DAL;
using Bucket.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bucket.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Application DB context
        /// </summary>
        protected IdentityContext ApplicationDbContext { get; set; }

        /// <summary>
        /// User manager - attached to application DB context
        /// </summary>
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public HomeController()
        {
            this.ApplicationDbContext = new IdentityContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.ApplicationDbContext));
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public ActionResult MainPanel()
        {
            ApplicationUser appUser = UserManager.FindById(User.Identity.GetUserId());
            User _user = new Models.User() { UserName = appUser.UserName, ApplicationUser = appUser };
            ApplicationDbContext.Users.Add(_user);
            ApplicationDbContext.SaveChanges();

            string currentUserId = UserManager.FindById(User.Identity.GetUserId()).Id;

            User model = ApplicationDbContext.Users.Where(u => u.ApplicationUserId == currentUserId).FirstOrDefault();

            return View(model);
        }

        public ActionResult MainPanelLogin()
        {
            string currentUserId = UserManager.FindById(User.Identity.GetUserId()).Id;

            User model = ApplicationDbContext.Users.Where(u => u.ApplicationUserId == currentUserId).FirstOrDefault();

            return View("MainPanel", model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}