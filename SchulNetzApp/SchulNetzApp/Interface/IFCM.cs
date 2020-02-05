using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchulNetzApp
{
    public interface IFCM
    {
        Task<string> FCM_Toggle(bool state);
    }
}
