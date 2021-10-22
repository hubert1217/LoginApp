using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace LoginApp.Models
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string login, string pass)
        {
            bool result = FormsAuthentication.Authenticate(login, pass);

            if (result) 
            {
                FormsAuthentication.SetAuthCookie(login, false);
            }

            return result;
        }
    }
}