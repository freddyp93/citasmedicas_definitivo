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
    public partial class solicitarCita : ContentPage
    {
        public solicitarCita()
        {
            InitializeComponent();
        }

        private void Reservarcita_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingreso());
        }
    }
}