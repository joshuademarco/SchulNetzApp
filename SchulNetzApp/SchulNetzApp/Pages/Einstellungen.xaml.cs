using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchulNetzApp;
using System.ComponentModel;

namespace SchulNetzApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class Einstellungen : ContentPage
    {
        IFirestore IFire;
        public Einstellungen()
        {
            InitializeComponent();
            IFire = DependencyService.Get<IFirestore>();
        }

        private async void LogoutBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["IsLoggedIn"] = false;
            App.IsUserLoggedIn = false;
            AccountStorage.DeleteCredentials();
            await Navigation.PushModalAsync(new Login(), true);
        }

        private async void RtvBtn_Clicked(object sender, EventArgs e)
        {
            string answer = await IFire.RetrieveFirestore(await SecureStorage.GetAsync("uid_token"));
            Debug.WriteLine(answer);
        }
    }
}