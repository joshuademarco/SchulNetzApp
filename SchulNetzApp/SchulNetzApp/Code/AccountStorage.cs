using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Windows.System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SchulNetzApp
{
    public class AccountStorage
    {
        public static async void SaveCredentials(string username  ,string password, string Token)
        {
            if(!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    await SecureStorage.SetAsync("username_token" , username);
                    await SecureStorage.SetAsync("password_token" , password);
                    await SecureStorage.SetAsync("token_token", Token);
                }
                catch (Exception e)
                {
                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("An Error Occured while accesssing the Secure Storage"); });
                }
            }
        }
    }
}
