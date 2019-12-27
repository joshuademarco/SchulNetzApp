using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lottie.Forms;
using Xamarin.Essentials;



namespace SchulNetzApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class Login : ContentPage
    {

        IFirebaseAuthenticator IAuth;
        public Login()
        {
            onstartsub();
            InitializeComponent();
            IAuth = DependencyService.Get<IFirebaseAuthenticator>();

        }

        public IUser usercred = new IUser { };


        async void onstartsub()
        {
            if (!(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))) && !(string.IsNullOrWhiteSpace(await SecureStorage.GetAsync("username_token"))))
            {
                await Navigation.PushModalAsync(new MainPage(), false);
            }
        }

        public async void Login_click(object sender, EventArgs e)
        {
            animationView.Loop = true;
            animationView.Animation = "lf30_editor_piMsMY.json";


            if (string.IsNullOrWhiteSpace(UserInput.Text) || string.IsNullOrWhiteSpace(PassInput.Text))
            {
                animationView.Loop = false;
                animationView.Animation = "6973-incorrect-failed.json";
            }
            else
            {
                usercred.Username = UserInput.Text;
                usercred.Password = PassInput.Text;


                

                    string Token = await IAuth.LoginWithEmailPassword(usercred.Username, usercred.Password);
                    if (Token != null)
                    {
                        Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("Login with Firebase Succesfull. Firebase UserToken: {0})", Token); });
                        animationView.Loop = false;
                        animationView.Animation = "6518-correct-check-animation.json";
                        usercred.UID = await SecureStorage.GetAsync("uid_token");
                        AccountStorage.SaveCredentials(usercred.Username, usercred.Password, Token, usercred.UID);
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        Application.Current.Properties["IsLoggedIn"] = true;
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

        async public void ShowError(IUser a)
        {
            await DisplayAlert(a.Username + a.Password, "Email or Password are incorrect!", "OK");
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}

