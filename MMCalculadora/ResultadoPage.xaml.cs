using System.Globalization;

namespace MMCalculadora;

public partial class ResultadoPage : ContentPage
{
    public decimal Troco { get; set; }
    public decimal TotalCliente { get; set; }
    public decimal GastoTotal { get; set; }

    public ResultadoPage(decimal troco, decimal gastoTotal, decimal totalCliente)
	{
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        Troco = troco;
        TotalCliente = gastoTotal;
        GastoTotal = totalCliente;

        InitializeComponent();
        changeLabelTotalCliente.Text = $"Gasto Total: {TotalCliente:C}";
        changeLabelTotalGasto.Text = $"Pagamento: {GastoTotal:C}";
        changeLabelTroco.Text = $"Troco: {Troco:C}";
    }

    private async void OnFinalizarChangeClicked(object sender, EventArgs e)
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