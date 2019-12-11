using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchulNetzApp
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailPassword(string username, string password);
    }
}