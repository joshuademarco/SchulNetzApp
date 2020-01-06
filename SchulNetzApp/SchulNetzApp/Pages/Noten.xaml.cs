using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchulNetzApp;


namespace SchulNetzApp.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Noten : ContentPage
    {
        public Noten()
        {
            InitializeComponent();
            
        }





        public DataManager.FachClass faecher;

        public DataTable DataTableCollection { get; set; }

        public async void UpdateComp()
        {            
            DataTableCollection = faecher.Faecher.Tables["Biologie"]; //Problematisch

            var table = NotenTable;
            var Fach = new TableSection();
            var Cell = new ViewCell();
            foreach (DataTable tables in faecher.Faecher.Tables)
            {
            }
        }
    }
}