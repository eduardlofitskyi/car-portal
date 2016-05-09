using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auto.Controllers
{
    public class LogoutController : Controller
    {
        //
        // GET: /Logout/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            Session["Cart"] = null;

            return Redirect("/Hello/Index");
        }

    }
}
