using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Models
{
    public interface IAuthProvider
    {
        bool Authenticate(string login, string pass);
    }
}
