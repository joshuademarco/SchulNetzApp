using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchulNetzApp;
using Xamarin.Essentials;

namespace SchulNetzApp.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Noten : ContentPage
    {
        IFirestore IFire;
        public Noten()
        {
            
            InitializeComponent();
            IFire = DependencyService.Get<IFirestore>();
            RtvAllTableUpdate();
        }





        public async void RtvAllTableUpdate()
        {
            //DataTableCollection = faecher.Faecher.Tables["Biologie"]; //Problematisch

            //var table = new TableView
            //{
            //    Intent = TableIntent.Data, Root = new TableRoot
            //    {
            //        new TableSection
            //        {
            //            new ViewCell()
            //        }
            //    }
            //};


            Dictionary<string, Dictionary<string, object>> faecher = await IFire.RtvAllF(await SecureStorage.GetAsync("uid_token"));

            var table = new TableView() {Intent=TableIntent.Data};
            var root = new TableRoot();
            
            foreach (KeyValuePair<string, Dictionary<string, object>> fach in faecher)
            {
                var section = new TableSection(fach.Key);
                
                //ew TableSection() {Title=fach.Key };
                foreach (KeyValuePair<string, object> test in fach.Value)
                {
                    

                    var layout = new StackLayout() { Orientation = StackOrientation.Horizontal };
   
                    layout.Children.Add(new Label()
                    {
                        Text = test.Key,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Margin = new Thickness (25,0,0,0),

                    });
                    
                    if (Convert.ToDecimal(test.Value) < 4)
                    {
                        layout.Children.Add(new Label()
                        {
                            Text = test.Value.ToString(),
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            Margin = new Thickness(0, 0, 30, 0),
                            TextColor = Color.Orange
                        });
                    } else
                    {
                        layout.Children.Add(new Label()
                        {
                            Text = test.Value.ToString(),
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            Margin = new Thickness(0, 0, 30, 0),
                        });
                    }


                    //new ViewCell();
                    //new StackLayout();
                    //new Label() {Text=test.Key };
                    //new Label() { Text = test.Value.ToString() };
                    section.Add(new ViewCell() { View = layout });
                }

                root.Add(section);

            }
            table.Root = root;
            var cont = new StackLayout() { Margin = new Thickness(0, 25, 0, 0) };
            var tit = new Label() { Text = "Noten", FontSize = 30, ClassId = "Noten_Class", Margin = new Thickness(20, 0, 0, 30) };
            cont.Children.Add(tit);
            cont.Children.Add(table);

            Content = cont;

        }
    }
}