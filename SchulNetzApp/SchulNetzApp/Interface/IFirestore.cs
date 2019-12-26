using SchulNetzApp.Pages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulNetzApp
{
    public interface IFirestore
    {


        Task<string> RetrieveFirestore(string answer, string Token);

    }
}
