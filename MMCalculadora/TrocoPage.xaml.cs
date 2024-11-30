namespace MMCalculadora;

public partial class TrocoPage : ContentPage
{
    public decimal TotalGasto { get; set; }
    public TrocoPage(string totalGasto)
    {
        TotalGasto = decimal.Parse(totalGasto);
        InitializeComponent();
        totalAmountEntry.Text = TotalGasto.ToString();
    }

    private async void OnCalculateChangeClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(givenAmountEntry.Text))
        {
            DisplayAlert("Erro", "Preencha o Pagamento do Cliente", "OK");
            return;
        }

        decimal givenAmount = decimal.Parse(givenAmountEntry.Text);

        if (givenAmount < TotalGasto)
        {
            DisplayAlert("Erro", "O valor recebido é menor que o valor total.", "OK");
            return;
        }


        decimal change = givenAmount - TotalGasto;
        await Navigation.PushAsync(new ResultadoPage(change, TotalGasto, givenAmount));
    }
}