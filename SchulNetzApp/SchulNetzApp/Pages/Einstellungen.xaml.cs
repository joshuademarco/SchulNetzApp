using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchulNetzApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Einstellungen : ContentPage
    {
        public Einstellungen()
        {
            InitializeComponent();
        }

        private async void LogoutBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["IsLoggedIn"] = false;
            App.IsUserLoggedIn = false;
            AccountStorage.DeleteCredentials();
            await Navigation.PushModalAsync(new Login(), true);
        }
    }
}