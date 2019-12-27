using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using SchulNetzApp.Droid.Code;
using Xamarin.Essentials;
using Xamarin.Forms;
using SchulNetzApp;



[assembly: Xamarin.Forms.Dependency(typeof(AndroidFirebaseAuthenticator))]
    
namespace SchulNetzApp.Droid.Code
{


    public class AndroidFirebaseAuthenticator : IFirebaseAuthenticator
    {
    
        public async Task<string> LoginWithEmailPassword(string username, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.
                    SignInWithEmailAndPasswordAsync(username, password).ConfigureAwait(true);
                var token = await user.User.GetIdTokenAsync(false).ConfigureAwait(true);
                await SecureStorage.SetAsync("uid_token", user.User.Uid).ConfigureAwait(true);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.GetStackTrace();
                return null;
            }
            catch (FirebaseAuthEmailException e)
            {
                e.GetStackTrace();
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("An General Error occured! #002 {0}", e);
                return null;
            }
        }


    }
}