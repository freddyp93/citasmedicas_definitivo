using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace citasmedicas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rusuario : ContentPage
    {
        public Rusuario(string n, string a)
        {
            InitializeComponent();
            lblTexto.Text = "Bienvenido" + n + " " + a;
            string Nombre = txtNombre.Text;
            string Apellido = txtapellido.Text;
            string cedula = txtcedula.Text;
            string mail = txtmail.Text;
            string telefono = txttelefono.Text;
            string edad = txtedad.Text;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            // string Nombre = txtNombre.Text;
            //string Apellido = txtapellido.Text;
            ///string cedula = txtcedula.Text;
            //string mail = txtmail.Text;
            //string telefono = txttelefono.Text;
            //string edad = txtedad.Text;
            //await Application.Current.MainPage.Navigation.PushAsync(new Login(Nombre,Apellido,cedula,mail,telefono,edad));
        }
    }
}