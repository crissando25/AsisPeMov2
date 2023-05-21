using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Net.Http;
using static AsisPeMov2.Registro;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace AsisPeMov2.menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarDatos : ContentPage
    {
        private ObservableCollection<AsisPeMov2.Registro> _post;

        public MostrarDatos()
        {
            InitializeComponent();
            obtener();
        }
        public IEnumerable ItemsSource { get; set; }
        public async void obtener()
        {
            var url = "http://192.168.1.26/moviles/post.php";
            var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            List<AsisPeMov2.Registro> posts = JsonConvert.DeserializeObject<List<AsisPeMov2.Registro>>(content);
            _post = new ObservableCollection<AsisPeMov2.Registro>(posts);

            MyListView.ItemsSource = _post;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var url = "http://192.168.1.26/moviles/post.php";
            var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            List < AsisPeMov2.Registro> posts = JsonConvert.DeserializeObject<List<AsisPeMov2.Registro>>(content);
            _post = new ObservableCollection<AsisPeMov2.Registro>(posts);

            MyListView.ItemsSource = _post;
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
        public void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var mydetails = e.SelectedItem as Registro;
            string Id = mydetails.Id.ToString();
            string usuario = mydetails.usuario;
            string contraseña= mydetails.contraseña;
            string correo= mydetails.correo;
            string Rol = mydetails.Rol;
            string observaciones = mydetails.observaciones;
      
            //  DisplayAlert("ALERT", mydetails.codigo, "ok");
            Navigation.PushAsync(new Update(Id,usuario,contraseña, correo, Rol,observaciones));
        }

    }
}