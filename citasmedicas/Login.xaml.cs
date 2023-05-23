using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace citasmedicas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        //variables de conexion
        private const string Url = "http://172.18.64.1/citas_medicas/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<citasmedicas.Datos.Datos> _post;
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                Navigation.PushAsync(new Ingreso());
            }
            else
            {
                //bota la alerta y se limpia el cuadro 
               txtUsuario.Text = "";
               txtContrasena.Text = "";
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
            }

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registroUsuario());
        }

        private void btnOcontrasena_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reseteol());
        }

        private void btnRegistroGmail_Clicked(object sender, EventArgs e)
        {
            //llamo a la ventana para registro con gmail
            Navigation.PushAsync(new Registro_gmail());
        }

        private void btnIngresoGmail_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Ingreso());
        }
    }
}
