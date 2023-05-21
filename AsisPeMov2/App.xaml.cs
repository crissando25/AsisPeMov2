using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsisPeMov2
{
    public partial class App : Application
    {
        public static MasterDetailPage MAsterDet { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            MainPage = new NavigationPage(new MainPage());
            MainPage = new PickerPage();


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public class PickerPage : Page
        {
        }



    }
}

