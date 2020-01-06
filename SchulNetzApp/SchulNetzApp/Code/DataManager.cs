using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SchulNetzApp
{
    
    public class DataManager
    {
        public class FachClass
        {

            public QuerySnapshot QsnapF { get; set; }
            public string FachName { get; set; }

            public void Invoke(List<Dictionary<string, object>> Faecher)
            {

            }

            public DataSet Faecher = new DataSet();
            


            public void Init(object sender, EventArgs e) {
            }
        }

        

    }

}
