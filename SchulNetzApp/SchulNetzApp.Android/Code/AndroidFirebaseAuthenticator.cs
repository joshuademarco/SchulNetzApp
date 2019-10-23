using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;

namespace SchulNetzApp.Droid.Code
{
    public class AndroidFirebaseAuthenticator : IFirebaseAuthenticator
    {
        public async Task<string> LoginWithUserPassword(User usercred)
        {
            var cred = await FirebaseAuth.Instance.
                SignInWithEmailAndPasswordAsync(usercred.Username, usercred.Password);
            var token = await cred.User.GetIdTokenAsync(false);
            return token.Token;

        }

    }
}