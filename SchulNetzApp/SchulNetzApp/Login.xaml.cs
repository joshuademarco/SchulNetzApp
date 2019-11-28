using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lottie.Forms;

namespace SchulNetzApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class Login : ContentPage
    {

        IFirebaseAuthenticator IAuth;
        public Login()
        {
            InitializeComponent();
            IAuth = DependencyService.Get<IFirebaseAuthenticator>();

           
        }
        

        public async void Login_click(object sender, EventArgs e)
        {
            animationView.Loop = true;
            animationView.Animation = "lf30_editor_piMsMY.json";


            if (string.IsNullOrEmpty(UserInput.Text) || string.IsNullOrEmpty(PassInput.Text))
            {
                animationView.Loop = false;
                animationView.Animation = "6973-incorrect-failed.json";
                throw new ApplicationException("Nothing Filled in");
            }
            else
            {
               var usercred = new User // nicht public??
                {
                    Username = UserInput.Text,
                    Password = PassInput.Text
                };


                

                    string Token = await IAuth.LoginWithEmailPassword(usercred.Username, usercred.Password);
                    if (Token != null)
                    {
                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("Login with Firebase Succesfull. Firebase UserToken: {0})", Token); });
                    animationView.Loop = false;
                    animationView.Animation = "6518-correct-check-animation.json";
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    App.IsUserLoggedIn = true;
                    await Navigation.PushModalAsync(new MainPage(), true); 
                    }
                    else
                    {
                    animationView.Loop = false;
                    animationView.Animation = "6973-incorrect-failed.json";
                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("Login with Firebase Failed. Firebase UserToken: {0})", Token); });
                }

                    //App.IsUserLoggedIn = true;

                    //Do Tick Animation

            }

        }

        async public void ShowError(User a)
        {
            await DisplayAlert(a.Username + a.Password, "Email or Password are incorrect!", "OK");
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}

