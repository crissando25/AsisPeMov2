using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsisPeMov2.menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void btnAcercaDe_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;//genera vista 
            await App.MAsterDet.Detail.Navigation.PushAsync(new Acerca());

        }
        private async void btnUsuarioNuevo_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;//genera vista 
            await App.MAsterDet.Detail.Navigation.PushAsync(new Registro());

        }

    }
}