﻿using System;
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
        public static async void SaveCredentials(string username  ,string password, string Token, string UID)
        {
            if(!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    await SecureStorage.SetAsync("username_token" , username);
                    await SecureStorage.SetAsync("password_token" , password);
                    await SecureStorage.SetAsync("token_token", Token);
                    await SecureStorage.SetAsync("uid_token", UID);
                }
                catch (Exception e)
                {
                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("An Error Occured while accesssing the Secure Storage"); });
                }
            }
        }
        public static void DeleteCredentials()
        {
            try
            {
                SecureStorage.RemoveAll();
            }
            catch (Exception e)
            {
                Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("An Error Occured while deleting the Secure Storage"); });
            }
        }
    }
}
