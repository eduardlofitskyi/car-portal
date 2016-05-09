using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using Auto.DAO.Context;
using Auto.Models;
using Auto.Utils;

namespace Auto.DAO.UserFolder
{
    public class UserDaoOrm : UserDAO
    {
        public UserLogin GetById(int id)
        {
            using (var db = new ProjectContext())
            {
                var query = from user in db.Users
                    where user.Id.Equals(id)
                    select user;

                return query.First();
            }
        }

        public UserLogin GetByLogin(string email, string pass)
        {

            using (var db = new ProjectContext())
            {
                var query = from user in db.Users
                            where user.Email.Equals(email.ToLower()) && user.Password.Equals(pass)
                            select user;

                foreach (var u in query)
                {
                    return u;
                }
            }

            return null;
        }

        public void AddNewUser(UserLogin user)
        {
            using (var db = new ProjectContext())
            {
                db.Users.Add(user);
                db.ShoppingCarts.Add(new ShoppingCart
                {
                    UserLogin = user,
                    Vehicles = new List<Vehicle>()
                });
                db.SaveChanges();
            }
        }

        public bool IsExist(string email)
        {
            using (var db = new ProjectContext())
            {
                var query = from user in db.Users
                    where user.Email.Equals(email.ToLower())
                    select user;
                foreach (var u in query)
                {
                    return true;
                }
            }

            return false;
        }
    }
}