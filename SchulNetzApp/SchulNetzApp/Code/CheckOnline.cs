using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;

namespace SchulNetzApp.Code
{
    public class CheckOnline
    {
        //Vars container?

            

        public static async Task checkonline(User user) {
            string url = "https://www.schul-netz.com/unterstrass/loginto.php?pageid=21311";


            using (HttpClient client = new HttpClient()) {

                try
                {
                    
                    string responseBody = await client.GetStringAsync(url);

                    Console.WriteLine(responseBody);

                }catch (HttpRequestException e){throw new ApplicationException("An Error occured while connecting");}

            }

        }


    }
}
