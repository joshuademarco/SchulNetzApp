using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        public Effect shadoweffect = Effect.Resolve("SchulNetz.ShadowEffect");



        public async void Login_click(object sender, EventArgs e)
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



                //var isValid = AreCredOk(usercred);
                 //isValid
                

                    string Token = await IAuth.LoginWithEmailPassword(usercred.Username, usercred.Password);
                    if (Token != null)
                    {
                    UserInput.Effects.Add(shadoweffect);
                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("Login with Firebase Succesfull. Firebase UserToken: {0})", Token); });

                    await Navigation.PushModalAsync(new MainPage());
                    }
                    else
                    {

                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("Login with Firebase Failed. Firebase UserToken: {0})", Token); });
                }

                    //App.IsUserLoggedIn = true;

                    // Navigate new Main as Mainpage
                    //await Navigation.PushModalAsync(new MainPage());

                    //Do Tick Animation

            }

        }

        async public void ShowError(User a)
        {
            await DisplayAlert(a.Username + a.Password, "Email or Password are incorrect!", "OK");
        }

    }
}

