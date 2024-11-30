using System.Globalization;

namespace MMCalculadora;

public partial class ResultadoPage : ContentPage
{
    public ResultadoPage(decimal totalPayment, decimal totalSpend, decimal change)
	{
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        InitializeComponent();
        changeLabelTotalPayment.Text = $"Pagamento: {totalPayment:C}";
        changeLabelTotalSpent.Text = $"Gasto Total: {totalSpend:C}";
        changeLabelChange.Text = $"Troco: {change:C}";
    }

    private async void OnFinishChangeClicked(object sender, EventArgs e)
    {
        bool resposta = await DisplayAlert("Compra confirmada", "Deseja voltar para o Inicio?", "Sim", "Não");

        if (resposta)
        {
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            return;
        }
       
    }

}