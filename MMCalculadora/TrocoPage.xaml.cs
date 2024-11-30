namespace MMCalculadora;

public partial class TrocoPage : ContentPage
{
    public decimal TotalSpent { get; set; }

    public TrocoPage(string totalSpent)
    {
        TotalSpent = decimal.Parse(totalSpent);
        InitializeComponent();
        totalAmountSpentEntry.Text = TotalSpent.ToString();
    }

    private async void OnCalculateChangeClicked(object sender, EventArgs e)
    {
        decimal change;
        decimal givenAmount;

        if (string.IsNullOrWhiteSpace(givenAmountEntry.Text))
        {
            await DisplayAlert("Erro", "Preencha o Pagamento do Cliente", "OK");
            return;
        }

        givenAmount = decimal.Parse(givenAmountEntry.Text);

        if (givenAmount < TotalSpent)
        {
            await DisplayAlert("Erro", "O valor recebido é menor que o valor total.", "OK");
            return;
        }

        change = givenAmount - TotalSpent;

        givenAmountEntry.IsEnabled = false;
        givenAmountEntry.IsEnabled = true;

        await Navigation.PushAsync(new ResultadoPage(givenAmount, TotalSpent, change));
    }
}