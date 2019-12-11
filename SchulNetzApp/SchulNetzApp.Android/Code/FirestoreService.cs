using Android.App;
using Android.Gms.Extensions;
using Android.Gms.Tasks;
using Firebase;
using Firebase.Firestore;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Essentials;

namespace SchulNetzApp {


    //    public class FirestoreServices : IOnSuccessListener
    //    {


    //        public FirebaseFirestore GetFirestore()
    //        {
    //            FirebaseFirestore database;
    //            var app = FirebaseApp.InitializeApp(Application.Context);
    //            if (app == null)
    //            {
    //                var options = new FirebaseOptions.Builder()
    //                    .SetProjectId("schulnetz-86ea4")
    //                    .SetApplicationId("schulnetz-86ea4")
    //                    .SetApiKey("AIzaSyB8Yy6tWEJmjW4cyZwU3BB7D336B0KGQkw")
    //                    .SetDatabaseUrl("https://schulnetz-86ea4.firebaseio.com")
    //                    .SetStorageBucket("schulnetz-86ea4.appspot.com")
    //                    .Build();

    //                app = FirebaseApp.InitializeApp(Application.Context, options);
    //                database = FirebaseFirestore.GetInstance(app);
    //            }
    //            else
    //            {
    //                database = FirebaseFirestore.GetInstance(app);
    //            }return database;
    //        }

    //        public new Array Fach;
    //        //public async void OnLoad(object sender, System.EventArgs e)
    //        //{
    //        //    HashMap noten = new HashMap();
    //        //    noten.Put("Test","1");

    //        //    FirebaseFirestore database = GetFirestore();
    //        //    string auth_uid = await SecureStorage.GetAsync("token_token");

    //        //    object items = database.Collection("SchulNetzDB").Document(auth_uid);
    //        //    foreach (var doc in items)
    //        //    {

    //        //    }

    //        //}


    //        //public void OnSuccess(Java.Lang.Object result)
    //        //{
    //        //    //var snapshot = (DocumentSnapshot)result;
    //        //    List<string> Fach = new List<string>();
    //        //    foreach (var e in result)
    //        //    {
    //        //        var snapshot = (DocumentSnapshot)e;
    //        //        string eF = snapshot.ToString();
    //        //        Fach.Add(eF);
    //        //        Debug.WriteLine(e + "Added!!!");
    //        //    };

    //        //}


    //        // INTERFACE IOnSuccessListener Exceptions

    //        public IntPtr Handle => throw new NotImplementedException();

    //        public void Dispose()
    //        {
    //            throw new NotImplementedException();
    //        }}



}