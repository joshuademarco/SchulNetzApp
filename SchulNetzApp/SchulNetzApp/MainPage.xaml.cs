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
            if (!App.IsUserLoggedIn){ Navigation.PushModalAsync(new Login(), true); Navigation.RemovePage(this); } //check if logged in
        }


        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
