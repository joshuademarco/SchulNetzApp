using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SchulNetzApp.Data
{
    public class DataBindings
    {
        public string Name { get; set; }
        public string ClassID { get; set; }
        public string LogoURL { get; set; }
        public static IList<DataBindings> All { get; set; }

        static DataBindings()
        {
            All = new ObservableCollection<DataBindings>
            {
                new DataBindings
                {
                    Name = "Noten",
                    ClassID = "Class_Noten",
                    LogoURL = ""
                },
                new DataBindings
                {
                    Name = "Agenda",
                    ClassID = "Class_Agenda",
                    LogoURL = ""
                },
                new DataBindings 
                {
                    Name = "Termine",
                    ClassID = "Class_Termine",
                    LogoURL = ""
                },
                new DataBindings 
                { 
                    Name = "Einstellungen",
                    ClassID = "class_Einstellungen",
                    LogoURL = ""
                }
            };
        }
    }
}