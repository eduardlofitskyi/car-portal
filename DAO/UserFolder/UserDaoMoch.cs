using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Auto.DAO.Context;
using Auto.Models;

namespace Auto.DAO.UserFolder
{
    public class UserDaoMoch : UserDAO
    {
        public UserLogin GetById(int id)
        {
            return new UserLogin();
        }
        public UserLogin GetByLogin(string email, string pass)
        {
            if (email.Equals("admin@admin.ru") && pass.Equals("96e79218965eb72c92a549dd5a330112".ToUpper()))
            {
                var user =  new UserLogin(1, "Admin","Administrator", "Ukrain", "22222222", email, pass, "2000-12-10");
                user.IsAdmin = false; 
                
                using (var db = new ProjectContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                
                return user;

            }
            return null;
        }

        public void AddNewUser(UserLogin user)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string email)
        {
            return false;
        }
    }
}