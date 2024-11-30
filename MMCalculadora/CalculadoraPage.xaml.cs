namespace MMCalculadora;

public partial class CalculadoraPage : ContentPage
{
    private decimal value = 0;
    private decimal previousValue = 0;

    public CalculadoraPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var buttonText = button.Text;

        if (displayEntry.Text == "0" || "+".Contains(displayEntry.Text))
        {
            displayEntry.Text = buttonText;
        }
        else
        {
            displayEntry.Text += buttonText;
        }
    }

    private void OnOperationClicked(object sender, EventArgs e)
    {
        previousValue = decimal.Parse(displayEntry.Text);
        value += previousValue;
        displayEntry.Text = "+"; 
    }

    private async void OnEqualClicked(object sender, EventArgs e)
    {
        previousValue = decimal.Parse(displayEntry.Text);
        value += previousValue;
        displayEntry.Text = value.ToString();

        await DisplayAlert("Total da Compra", value.ToString(), "OK");
        await Navigation.PushAsync(new TrocoPage(value.ToString()));
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        displayEntry.Text = "0";
        value = 0;
        previousValue = 0;
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {
        if (displayEntry.Text.Length > 1)
        {
            displayEntry.Text = displayEntry.Text[..^1];
        }
        else
        {
            displayEntry.Text = "0";
        }
    }

    private void OnDotClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var buttonText = button.Text;

        if (displayEntry.Text.Contains('.'))
        {
            return;
        }
        else
        {
            displayEntry.Text += buttonText;
        }
    }


}