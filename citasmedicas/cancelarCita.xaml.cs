using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace citasmedicas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cancelarCita : ContentPage
    {
        public cancelarCita()
        {
            InitializeComponent();
            
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
           var monkeyList = new List<string>();
                monkeyList.Add("Baboon");
                monkeyList.Add("Capuchin Monkey");
                monkeyList.Add("Blue Monkey");
                monkeyList.Add("Squirrel Monkey");
                monkeyList.Add("Golden Lion Tamarin");
                monkeyList.Add("Howler Monkey");
            monkeyList.Add("Japanese Macaque");
           
            var picker = new Picker { Title = "Select a monkey", TitleColor = Color.Red };
            picker.ItemsSource = monkeyList;
           
        }
    }
}