using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchulNetzApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }



        private async void Login_click(object sender, EventArgs args)
        {

            if (UserInput.Text.Length == 0 || PassInput.Text.Length == 0) //<--- not wworking
            {
                throw new ApplicationException("Nothing Filled in");
                
            }

            WebClient client = new WebClient();



        }

    }
}