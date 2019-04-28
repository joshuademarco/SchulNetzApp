using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SchulNetzApp.Code
{
    public class CheckOnline
    {



        public static async Task<bool> checkonline(User usercred)
        {
            string url = "https://www.schul-netz.com/unterstrass/loginto.php?pageid=21311";


            using (HttpClient client = new HttpClient())
            {
                try
                {

                    string responseBody = await client.GetStringAsync(url);



                    Device.BeginInvokeOnMainThread(() => { Debug.WriteLine(responseBody); });
                    return true;

                }
                catch (HttpRequestException e) { Device.BeginInvokeOnMainThread(() => { Debug.WriteLine("HttpClient Returned Exception: {0})", e.Message); }); return false; } //IF HttpClient Fails

            }

        }


    }
}
