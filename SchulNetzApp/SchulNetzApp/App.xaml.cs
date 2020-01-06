using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Foundation;

namespace SchulNetzApp
{
    public partial class App : Application
    {
        
        public static bool IsUserLoggedIn { get; set; }
        public string projectId = "schulnetz-86ea4";


        public App()
        {
            onstartsub();


            InitializeComponent();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            else
            {
                MainPage = new MainPage();

            }

            //FirestoreDb.Create(projectId

            //Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"C:\Users\joshu\Source\Repos\joshuademarco\SchulNetzApp\SchulNetzApp\SchulNetzApp\SchulNetz-165720c7a56c.json");
            //FirestoreDb.Create(projectId);
        }


            
        //public string jsonPath = File.ReadAllText("SchulNetz-165720c7a56c.json");



        async void onstartsub()
            {
                if (!(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))) && !(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))))
                {
                IsUserLoggedIn = true;
                }
            }
        protected override void OnStart()
        {
            // Handle when your app starts

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps

        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        //    async void OnResumeSub() { 
        //    if (!(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))) && !(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))))
        //    {
        //        MainPage = new NavigationPage(new MainPage());
        //    }
        //}
    }

    
    }
}
