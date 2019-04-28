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

            if (string.IsNullOrEmpty(UserInput.Text) || string.IsNullOrEmpty(PassInput.Text)) //<--- not wworking
            {
                throw new ApplicationException("Nothing Filled in");
            }else{

                var usercred = new User // nicht public
                {
                    Username = UserInput.Text,
                    Password = PassInput.Text
                };

                var isValid = AreCredOk(usercred);
                if (isValid) {
                    App.IsUserLoggedIn = true;
                    Navigation.PushAsync() // Navigate new Main as Mainpage;
                    //Do Tick Animation
                }
                else
                { 
                    //Make Cross Animation
                }
            

                }

            }

        
        public bool AreCredOk(User user) {
            return true; //CheckOnline Referrenz
        }


        }

    }
