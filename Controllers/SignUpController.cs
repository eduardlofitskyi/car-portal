using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.DAO;
using Auto.DAO.Context;
using Auto.DAO.UserFolder;
using Auto.Models;
using Auto.Utils;

namespace Auto.Controllers
{
    public class SignUpController : Controller
    {
        //
        // GET: /SignUp/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp(FormCollection collection)
        {

            UserDAO dao = new UserDaoOrm(); //TODO: IoC - dependency injection

            string name = collection.Get("regName");
            string sureName = collection.Get("regLName");
            string date = collection.Get("datetimepicker1");
            string city = collection.Get("regCity");
            string phone = collection.Get("regPhone");
            string email = collection.Get("regEmail");
            string pass = collection.Get("regConPass");
            string passConfirm = collection.Get("regConPass");

            if (!pass.Equals(passConfirm))
            {
                return Redirect("/Hello/Index");
            }

            pass = MD5Hash.Do(pass);
            var user = new UserLogin() {Name = name, Surname = sureName, Town = city, PhoneNumber = phone, Email = email, Password = pass, Birth = date};

            bool isEx = dao.IsExist(email);

            if (isEx.Equals(true))
            {
                return View("~/Views/Hello/ViewErrorReg.cshtml", user);
            }

            dao.AddNewUser(user);

            return Redirect("/Hello/Index");
            //return Redirect("http://localhost:51487/Hello/Index");
            //return View(Index());
        }
    }
}
