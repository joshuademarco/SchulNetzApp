using Android.App;
using Android.Gms.Extensions;
using Android.Gms.Tasks;
using Firebase;
using Firebase.Firestore;
using Java.Util;
using SchulNetzApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(FirestoreService))]


namespace SchulNetzApp
{

    
    public class FirestoreService : IFirestore
    {

        public async Task<string> RetrieveFirestore(string answer)
        { 

            answer = "Successs!";
            return answer;
        }
    }
}