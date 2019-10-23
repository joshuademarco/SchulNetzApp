using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchulNetzApp
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithUserPassword(User usercred);
    }
}