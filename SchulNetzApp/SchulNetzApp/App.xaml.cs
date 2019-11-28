using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SchulNetzApp
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {

            InitializeComponent();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
           // async void onStartSub() {
           // if (!(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))) && !(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))))
           // {
           //     MainPage = new NavigationPage(new MainPage());
           // }
           //}
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
