using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OauthP.Models
{
    public class UserService
    {
                public User GetUserByCredentials(string email, string password)
        {
            if (email.Equals("admin") && password.Equals("admin"))
                return new User() { Id = "1", Email = "email@domain.com", Password = "password", Name = "Ole Petter Dahlmann" };
            else return null;
        }
    }
}