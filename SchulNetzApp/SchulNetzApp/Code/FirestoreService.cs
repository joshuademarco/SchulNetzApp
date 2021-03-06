﻿
using Google.Cloud.Firestore;
using SchulNetzApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Linq;
using SchulNetzApp;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using System.Reflection;
using System.IO;
using Google.Cloud.Firestore.V1;
using Grpc.Core;
using Grpc.Auth;

[assembly: Xamarin.Forms.Dependency(typeof(FirestoreService))]


namespace SchulNetzApp
{



    public class FirestoreService : DataManager, IFirestore
    {
        public FachClass faecher;

        public string projectId = "schulnetz-86ea4";

        public FirestoreDb db = FirestoreDb.Create("schulnetz-86ea4", FirestoreClient.Create(new Channel(FirestoreClient.DefaultEndpoint.Host, FirestoreClient.DefaultEndpoint.Port, GoogleCredential.FromJson(@"{
                  'type': 'service_account',
                  'project_id': 'schulnetz-86ea4',
                  'private_key_id': '165720c7a56c3b9f847a0d93590290720b3d3a66',
                  'private_key': '-----BEGIN PRIVATE KEY-----\nMIIEvwIBADANBgkqhkiG9w0BAQEFAASCBKkwggSlAgEAAoIBAQDtSKxOqjOWYVrQ\nfogn556tsWghx8m08z6/W3C5DQQyENgTnmlAMZbMFOtSCnfGWf58iG2qoJ/iWkM5\nZ1oYhrNhky1FzoXiBJlBaeLARucuvvAkKCHfWhgCwzxHvVFzN7kwmoGg8dOr2XpE\noQN9/eIhX3stQKn87ukrrY6HM8xgRsl7+EcYOZt1HMGf+XZmT3V6Lczw4VXgH6RG\nm4KUNQsz20zKW50Sg9QVVeSK+PT8KNFGl+plyTjFL9K5DkGtyDa6TYdNvBimBBQS\nQZ5Mt/W4SC/ZMbxk1lw9Y9EUN0SV2cL247c0IAx4RrIcbFeiQPS/uUY4qHaG96ni\nR2OH3LCNAgMBAAECggEADt0ijhBIsv7eOs6c+4Ly2bE8ngEZ4uU/OlV2tjYuhm8F\nBMBDmkCA+xUZuJtB7YGYWMy4XJvl6BP8v2J4rlihxqxQMF3uMmj/VgMABUjBFUM4\ntSBzyWinYGTtKGv054wcua1euWpB9t3ktC/ckXk56m/vaLedmQ6OOgI2j27wj9yV\nweWvs78FPHWk7DyP9cKp3P2DNtRMhV9kjzOzGNZZ1PfjZTAwOyUUaI3Ex3xjPVg2\nyhwwFYRzu1Uie/mqOz0SnOwIDM/gn63XtM8JhZdUbT+WWwYYnqa6SlhOl7NcV8pt\nARHoxb04ctvvcZxwfoJ8tdCKVkBRYuTpIjYq7ht6MQKBgQD8rMZ3OcstYt/XFVsI\n9b8sNW1hc7l5KqOikqf+Td+4bz0CS70ZpCzpdLJwCf5AZT2VD4OtpTd82RV7mBva\np1v0IyfUc1X9hF1KTrPtOMnBKgKQ+SEi3FdZ4G4MUaA/ntc0N2/0WSOWH53/N+/E\n3RhKUVijzYp7GhEyEKNRqngBKwKBgQDwaAw24MGDOOLzke0RwOIfjUrCL8d0rMJ5\nrxzctNMJZPqO2toJ/9e79w42O+Wqll72j9t6wR4rWTd+YvQtWZwzqpq0YViMEYi6\nd2OPCGdNoQ/EoEPr9x5BEeKrkSnukaa3mlrJR4fsp7Rx3FiGHVrZo1hkzQ+0OGBa\n8IflXZ4JJwKBgQCrrPhrqWjSvYs4p9nijJYHg4V94RLzsHTd0KczsdV/ipT5Klyh\nP1sEg7V5SlDlj+P3k0L0iHza5uQhxYenWG6xwfEd9/9E8Nox0qeNVjg+djyoI5zQ\nAsWW21XqKMuoblPptoDqlGYJahH/hhHywAXw+LQxF0YvvdZRHdzZb+l5YQKBgQCn\nZ4y52iBmhAJlocP3jNzpI7ZfKm41rOdvXKU4eyJJdGuVdohGVkWfuhXHZkYzV6qg\n/uPSww+DGAkwlS97NN80iyRXX0INp1gSoHhPbYah4/na7c7eTaJfpVi2J8uPORVi\n3LVDW/Amt1FLyChMm7xbuQcgijrZQDi4mq3G5j3aGQKBgQDoQ5IeiYBiKECftxz3\nAttCwnMMldqBLfTfJM3wdfvZEZhEMuw+WnxTHfKXHWk4DirpNClQLfRBN1ZcMM73\nW/9M3+Rk8BZpII9a1V0kNCOrUyBUvNKkz24YH/GD5uJZr8b6CtlMEex5jqlaWHXf\nBgp7+4FlHfm1FZuKCu5NX6emlQ==\n-----END PRIVATE KEY-----\n',
                  'client_email': 'schulnetzdienstkonto@schulnetz-86ea4.iam.gserviceaccount.com',
                  'client_id': '113527659346642510203',
                  'auth_uri': 'https://accounts.google.com/o/oauth2/auth',
                  'token_uri': 'https://oauth2.googleapis.com/token',
                  'auth_provider_x509_cert_url': 'https://www.googleapis.com/oauth2/v1/certs',
                  'client_x509_cert_url': 'https://www.googleapis.com/robot/v1/metadata/x509/schulnetzdienstkonto%40schulnetz-86ea4.iam.gserviceaccount.com'
                }").CreateScoped(FirestoreClient.DefaultScopes).ToChannelCredentials())));



        //public async Task<string> RetrieveFirestore(string UID)
        //{

        //    //try
        //    //{
        //    //    DocumentReference docRef = FirebaseFirestore.Instance
        //    //        .Collection("SchulNetzDB")
        //    //        .Document(UID);
        //    //    await docRef.Set(hash);
        //    //    return "Sucess!";
        //    //}
        //    //catch(System.Exception e)
        //    //{
        //    //    return e.ToString();
        //    //}
        //}




        public async Task<string> RtvAllF(string UID)
        {

            Query RtvAllQ = db.Collection("SchulNetzDB").Document(UID).Collection("Fach");
            QuerySnapshot qsnap = await RtvAllQ.GetSnapshotAsync();
            foreach (DocumentSnapshot snap in qsnap)
            {
                string ID = snap.Id;
                Console.WriteLine("Document data for {0} document:", ID);
                if (snap.Exists)
                    Console.WriteLine("New Fach: {0}", ID);
            
                Dictionary<string, object> tests = snap.ToDictionary();
                foreach (KeyValuePair<string, object> test in tests)
                {
                    Console.WriteLine("{0}: {1}", test.Key, test.Value);
                }
            }
            return "Finish!";
        }


        public void CreateTable(string ID)
        {
            faecher.Faecher.Tables.Add(ID);

            var table = faecher.Faecher.Tables[ID];
            table.Columns.Add("Test", typeof(string));
            table.Columns.Add("Note", typeof(int));
        }

            //try 
            //{
            //    CollectionReference docRef = FirebaseFirestore.Instance
            //        .Collection("SchulNetzDB")
            //        .Document(UID)
            //        .Collection("Fach");

            //    await docRef.Get().AddOnSuccessListener(this);

            //    return "Success!";
            //}
            //catch (System.Exception e)
            //{
            //    throw new Exception(e.ToString());
            //}
      


        public async Task<string> RtvListen(string UID)
        {
            DocumentReference collRef = db.Collection("SchulNetzDB").Document(UID);
            FirestoreChangeListener listener = collRef.Listen(snapshot =>
            {
                Console.WriteLine("Callback received document snapshot.");
                Console.WriteLine("Document exists? {0}", snapshot.Exists);
                if (snapshot.Exists)
                {
                    Console.WriteLine("Document data for {0} document:", snapshot.Id);
                    Dictionary<string, object> city = snapshot.ToDictionary();
                    foreach (KeyValuePair<string, object> pair in city)
                    {
                        Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                    }
                }
            });
            return "Success!";
        }



        //    var snap = (QuerySnapshot)result;
        //    if (!snap.IsEmpty)
        //    {
        //        var docs = snap.Documents;

        //        foreach (DocumentSnapshot item in docs)
        //        {
        //            Debug.WriteLine(item);
        //        }
        //    }
        //}
    }
}