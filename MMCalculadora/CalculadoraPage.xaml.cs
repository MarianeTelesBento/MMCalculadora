namespace MMCalculadora;

public partial class CalculadoraPage : ContentPage
{
    /*
        Arrumar pag inicial; implementar: multiplica??o, Subtra??o; Vincular a soma no resulado; Bot?o de apagar um digito apenas.
     */
    private decimal value = 0;
    private decimal _previousValue = 0;
    private string _currentOperation = string.Empty;

    public CalculadoraPage()
    {
        InitializeComponent();
    }

    // M?todo para lidar com os n?meros
    private void OnButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var buttonText = button.Text;

        // Se o display for "0", substitui pelo n?mero
        if (displayEntry.Text == "0" || "+".Contains(displayEntry.Text))
        {
            displayEntry.Text = buttonText;
        }
        else
        {
            // Se n?o, adiciona o n?mero ? string
            displayEntry.Text += buttonText;
        }
    }

    // M?todo para lidar com as opera??es (+, -, *, /)
    private void OnOperationClicked(object sender, EventArgs e)
    {
        _previousValue = decimal.Parse(displayEntry.Text);
        value += _previousValue;
        displayEntry.Text = "+"; // Reseta o display para o pr?ximo n?mero
    }

    // M?todo para calcular o resultado
    private async void OnEqualClicked(object sender, EventArgs e)
    {
        _previousValue = decimal.Parse(displayEntry.Text);
        value += _previousValue;
        // Exibe o resultado (Mandar para a p?gina de Calculo da subtra??o da compra)
        displayEntry.Text = value.ToString();

        DisplayAlert("Total da Compra", value.ToString(), "OK");
        await Navigation.PushAsync(new TrocoPage(value.ToString()));
        //Mensagem de texto
    }

    // Metodo para limpar o display
    private void OnClearClicked(object sender, EventArgs e)
    {
        displayEntry.Text = "0";
        value = 0;
        _previousValue = 0;
        _currentOperation = string.Empty;
    }
    private void OnDeleteClicked(object sender, EventArgs e)
    {
        if (displayEntry.Text.Length > 1)
        {
            displayEntry.Text = displayEntry.Text.Substring(0, displayEntry.Text.Length - 1);
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

        if (displayEntry.Text.Contains("."))
        {
            return;
        }
        else
        {
            displayEntry.Text += buttonText;
        }


    }


}