using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace citasmedicas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registroPaciente : ContentPage
    {
        public registroPaciente()
        {
            InitializeComponent();
        }

        private void registrarfoto_Clicked(object sender, EventArgs e)
        {

        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //variables web client
                WebClient cliente = new WebClient();
                //guardo los datos que voy a insertar en la base de datos
                var parametros = new System.Collections.Specialized.NameValueCollection();

                //agrego los datos a la base de datos
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("cedula", txtCedula.Text);
                parametros.Add("historia_clin",txtHistoria.Text);
                parametros.Add("email", txtMail.Text);
                parametros.Add("telefono", txtTelefono.Text);
                parametros.Add("edad", txtEdad.Text);
                parametros.Add("especialidad", txtEspecialidad.Text);
                parametros.Add("horario", txthorario.Text);

                //envio los datos a mi servidor
                cliente.UploadValues("http://172.18.64.1/citas_medicas/post.php", "put",parametros);
                DisplayAlert("ALERTA", "DATOS INGRESADOS", "SALIR");


            }
            catch (Exception ex)
            {

                DisplayAlert("ALERTA", ex.Message, "Cerrar");
            }
        }
    }
}