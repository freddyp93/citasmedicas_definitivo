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
    public partial class CitasAsignadas : ContentPage
    {
        //variables de conexion
        private const string Url = "http://172.18.64.1/citas_medicas/post.php";
        private readonly HttpClient cliente = new HttpClient();
        private ObservableCollection<citasmedicas.Datos.Datos> _post;

        public CitasAsignadas()
        {
            InitializeComponent();
            //ejecuto el metodo
            Obtener();
        }
        public async void Obtener()
        {
            //envio datos de la base 
            var content = await cliente.GetStringAsync(Url);
            List<citasmedicas.Datos.Datos> posts = JsonConvert.DeserializeObject<List<citasmedicas.Datos.Datos>>(content);
            _post = new ObservableCollection<citasmedicas.Datos.Datos>(posts);

            MyListView.ItemsSource = _post;
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Datos.Datos)e.SelectedItem;

        }
    }
}