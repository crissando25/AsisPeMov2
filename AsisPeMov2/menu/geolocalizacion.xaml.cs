using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsisPeMov2.menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class geolocalizacion : ContentPage
	{
		public geolocalizacion ()
		{
			InitializeComponent ();
		}

        private async void Localizar()
        {
            var locator = CrossGeolocator.Current; //acceso a la app
            locator.DesiredAccuracy = 50; //Presicion (metros)
            if (locator.IsGeolocationAvailable) //servicio existente en el dispositivo
            {
                if (locator.IsGeolocationEnabled) // GPS activado en el dispositivo
                {
                    if (!locator.IsListening) // comprurba si el dispositivo escuchga al servicio

                    {
                        await locator.StartListeningAsync(TimeSpan.FromSeconds(1), 5);//inicio de la escucha
                    }
                    locator.PositionChanged += (cambio, args) =>
                    {
                        var loc = args.Position;
                        lon.Text = loc.Longitude.ToString();
                        longi = double.Parse(lon.Text);
                        lat.Text = loc.Latitude.ToString();
                        lati = double.Parse(lat.Text);
                    };
                }

            }
        }

        private async void MostrarMapa(object sender, EventArgs args1)
        {
            MapLaunchOptions options = new MapLaunchOptions { Name = "Mi posicion Actual" };
            await Map.OpenAsync(lati, longi, options);

        }
    }
}