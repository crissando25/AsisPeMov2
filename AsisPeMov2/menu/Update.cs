using Xamarin.Forms;

namespace AsisPeMov2.menu
{
    internal class Update : Page
    {
        private string usuario;
        private string contraseña;
        private string correo;
        private string rol;
        private string observaciones;

        public Update(string usuario, string contraseña, string correo, string rol, string observaciones, string observaciones1)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.correo = correo;
            this.rol = rol;
            this.observaciones = observaciones;
        }
    }
}