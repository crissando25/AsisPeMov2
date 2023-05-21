using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsisPeMov2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Acceso_Clicked(object sender, EventArgs e)
        {
            
            string usuario = "criss";
            string contraseña= "123456";
            string Usu = txtUsu.Text;
            string Contra = txtCon.Text;

            if (usuario == Usu & contraseña == Contra)


            {
                _ = DisplayAlert("Alerta", "\n USUARIO CORRECTO", "\n Cerrar");
                await Application.Current.MainPage.Navigation.PushAsync(new Menu());
            }
            else
            {
                _ = DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");

            }
        }
        private async void Registrar_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Registro());
        }


    }
}
