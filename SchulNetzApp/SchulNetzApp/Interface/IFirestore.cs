using SchulNetzApp.Pages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulNetzApp
{
    public interface IFirestore
    {
        
        Task<Dictionary<string, Dictionary<string, object>>> RtvAllF(string UID);
        Task<string> RtvListen(string UID);
        Task<string> FCM_Toggles(string UID, bool state);

    }
}
