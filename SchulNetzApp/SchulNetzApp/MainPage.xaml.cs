using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SchulNetzApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : TabbedPage
    {
        



        public MainPage()
        {
            InitializeComponent();
            if (!App.IsUserLoggedIn){Navigation.PushModalAsync(new Login());} //check if logged in
            }
        




        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login(),true ); Navigation.RemovePage(this);
        }


    }
}
