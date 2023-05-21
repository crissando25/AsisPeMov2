using AsisPeMov2.menu;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace AsisPeMov2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        internal readonly string usuario;
        internal readonly string contraseña;
        internal readonly string correo;
        internal readonly string Rol;
        internal readonly string observaciones;

        public Registro()
        {
            InitializeComponent();
            BindingContext = new Login();
           
        }
        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Registro());
        }

        
        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("ID", txtbtl_login_id.Text);
                parametros.Add("Usuario", txtbtl_lg_usuario.Text);
                parametros.Add("Contraseña", txtbtl_lg_contraseña.Text);
                parametros.Add("Correo", txtbtl_lg_correo.Text);
                parametros.Add("Rol", txtbtl_lg_rol.Text);
                parametros.Add("Observaciones", txttbl_lg_observaciones.Text);

                cliente.UploadValues("http://192.168.1.26/moviles/post.php", "POST", parametros);
             
                DisplayAlert("Guardado", "Dato ingresado", "salir");

            }
            catch (Exception ex)
            {
                DisplayAlert("Dato Erroneo", ex.Message, "cerrar");
            }
        }
        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Master());
        }

        private void btnConsultar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MostrarDatos());
        }
    }
}