using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Microsoft.Maui.Controls;

namespace MMCalculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnCalculateChangeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculadoraPage());
        }
    }

}
