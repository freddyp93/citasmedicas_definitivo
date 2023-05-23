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
    public partial class Ingreso : ContentPage
    {
        //variables de conexion
        private const string Url = "http://172.18.64.1/citas_medicas/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<citasmedicas.Datos.Datos> _post;
        public Ingreso()
        {
            InitializeComponent();
            
        }
        // declaro metodo para que se inicie automatico
        
        private void btnregistrarpaciente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registroPaciente());
        }


        private void btnsolicitarcita_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new solicitarCita());
        }

        private void btncancelarcita_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new cancelarCita());
        }

        private  void btnConsultarCitas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CitasAsignadas());
       
        }
    }
}