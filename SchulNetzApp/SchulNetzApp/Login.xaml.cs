using System;
using System.Threading.Tasks;
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





        public async void Login_click(object sender, EventArgs args)
        {

            if (string.IsNullOrEmpty(UserInput.Text) || string.IsNullOrEmpty(PassInput.Text))
            {
                throw new ApplicationException("Nothing Filled in");

            }
            else
            {

                var usercred = new User // nicht public??
                {
                    Username = UserInput.Text,
                    Password = PassInput.Text
                };

                var isValid = AreCredOk(usercred);
                if (isValid)
                {


                    App.IsUserLoggedIn = true;

                    // Navigate new Main as Mainpage
                    await Navigation.PushModalAsync(new MainPage());

                    //Do Tick Animation
                }
                else
                {
                    //Make Cross Animation
                }


            }

        }




        public bool AreCredOk(User usercred)
        {
            return Code.CheckOnline.Checkonline(usercred); //CheckOnline-Refferenz DIDIT!
        }

    }
}

