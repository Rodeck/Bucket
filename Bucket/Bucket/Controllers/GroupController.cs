using Bucket.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bucket.Controllers
{
    public class GroupController : Controller
    {
        public IdentityContext db = new IdentityContext();

        // GET: Group
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGroup()
        {
            return PartialView("_AddGroup");
        }

        public ActionResult SearchForPeople(string searchTerm)
        {
            var model = db.Users.Where(u => u.UserName.Contains(searchTerm)).ToList();
            return PartialView("_UserList", model);
        }
    }
}