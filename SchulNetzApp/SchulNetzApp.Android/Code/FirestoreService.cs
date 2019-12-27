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
using System.Linq;
using Android.Runtime;

[assembly: Xamarin.Forms.Dependency(typeof(FirestoreService))]


namespace SchulNetzApp
{

    
    public class FirestoreService : IFirestore
    {

        public async Task<string> RetrieveFirestore(string UID)
        {
        JavaDictionary<string, object> hash = new JavaDictionary<string, object> {
            {"name: ", UID},
        };
            try
            {
                DocumentReference docRef = FirebaseFirestore.Instance
                    .Collection("SchulNetzDB")
                    .Document(UID);
                await docRef.Set(hash);
                return "Sucess!";
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
    }
}