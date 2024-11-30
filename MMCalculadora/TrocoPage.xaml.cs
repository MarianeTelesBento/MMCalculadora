namespace MMCalculadora;

public partial class TrocoPage : ContentPage
{
    public decimal TotalGasto { get; set; }
    public TrocoPage(string totalGasto)
	{
        TotalGasto = decimal.Parse(totalGasto);
		InitializeComponent();
	}

    private async void OnCalculateChangeClicked(object sender, EventArgs e)
    {
        totalAmountEntry.Text = TotalGasto.ToString();
        decimal givenAmount = decimal.Parse(givenAmountEntry.Text);

        if (givenAmount < TotalGasto)
        {
            DisplayAlert("Erro", "O valor recebido é menor que o valor total.", "OK");
            return;
        }

        decimal change = givenAmount - TotalGasto;

        await Navigation.PushAsync(new ResultadoPage(change));
    }
}