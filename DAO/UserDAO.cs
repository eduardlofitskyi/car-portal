using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto.Models;

namespace Auto.DAO
{
    interface UserDAO
    {
        UserLogin GetByLogin(string email, string pass);
        
        void AddNewUser(UserLogin user);

        bool IsExist(string email);

        UserLogin GetById(int id);
    }
}
