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
    public partial class Reseteol : ContentPage
    {
        public Reseteol()
        {
            InitializeComponent();
        }


        private async void btnGuardarConta_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Login());
        }

        private void btnCancelarContra_Clicked(object sender, EventArgs e)
        {

        }
    }
}