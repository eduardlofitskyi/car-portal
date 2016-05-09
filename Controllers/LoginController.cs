using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;
using Auto.DAO;
using Auto.DAO.Context;
using Auto.DAO.UserFolder;
using Auto.Models;
using Auto.Utils;

namespace Auto.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        /*public ActionResult Login(string email, string password)
        {
            string myEmail = email;
            string myPass = password;

            return Redirect("Hello/Index");
        }*/
        public ActionResult Login(FormCollection collection)
        {
            
            UserDAO dao = new UserDaoOrm(); //TODO: IoC - dependency injection

            string email = collection.Get("email");
            string pass = collection.Get("password");

            pass = MD5Hash.Do(pass);
            UserLogin user = dao.GetByLogin(email, pass);
            Session["User"] = user;
            using (var db = new ProjectContext())
            {
                var query = from shopCart in db.ShoppingCarts
                    where shopCart.Id.Equals(user.Id)
                    select shopCart;

                List<Vehicle> list = query.First().Vehicles.ToList();
                Session["Cart"] = list;
            }

            return Redirect("/Hello/Index");

            //return Redirect("http://localhost:51487/Hello/Index");
            //return View(Index());
        }
    }
}   
