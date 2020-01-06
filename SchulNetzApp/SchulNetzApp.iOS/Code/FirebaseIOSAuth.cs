using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace SchulNetzApp.iOS.Code
{
    class FirebaseIOSAuth
    {
       

    [Register("AppDelegate")]

        public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate

        {

            public override bool FinishedLaunching(UIApplication app, NSDictionary options)

            {

                global::Xamarin.Forms.Forms.Init();

                LoadApplication(new App());



                Firebase.Core.App.Configure();

                return base.FinishedLaunching(app, options);

            }
        }
    } 
}