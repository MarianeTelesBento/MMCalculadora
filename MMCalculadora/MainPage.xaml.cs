using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

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
            /*decimal totalAmount = decimal.Parse(totalAmountEntry.Text);
            decimal givenAmount = decimal.Parse(givenAmountEntry.Text);

            if (givenAmount < totalAmount)
            {
                DisplayAlert("Erro", "O valor recebido é menor que o valor total.", "OK");
                return;
            }

            decimal change = givenAmount - totalAmount;

            await Navigation.PushAsync(new ResultadoPage(change));*/
            await Navigation.PushAsync(new CalculadoraPage());
        }
            
        
    }

}
