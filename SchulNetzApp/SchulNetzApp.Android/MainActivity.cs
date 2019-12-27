using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.OS;
using Android.Gms.Common;
using Android.Support.V7.App;
using Firebase.Messaging;
using Firebase;
using Firebase.Firestore;

namespace SchulNetzApp.Droid
{
    [Activity(Label = "SchulNetzApp", Icon = "@mipmap/icon",  Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            var Fapp = FirebaseApp.InitializeApp(Application.Context);
            FirebaseFirestore.GetInstance(Fapp);

            base.OnCreate(savedInstanceState);



            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            
            LoadApplication(new App());


            //IsPlayServicesAvailable();


        }
        //private bool IsPlayServicesAvailable()
        //{
          //  FirebaseApp.InitializeApp(Application.Context);
            //int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
           // if (resultCode != ConnectionResult.Success)
            //{
              //  if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode)) {
               //     msgText.Text = "Dive has an error";
                //} else {
                 //   msgText.Text = "This device is not supported";
                //} 
                //return false;
                //} else {
                    //msgText.Text = "Google Play Services is available";
                  //  FirebaseMessaging.Instance.SubscribeToTopic("SchulNetz_topic");
                    //return true;
               // }
        //}
 

       // public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
          //  Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            //base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
       // }

    }
}