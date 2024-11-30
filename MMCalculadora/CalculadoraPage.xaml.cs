namespace MMCalculadora;

public partial class CalculadoraPage : ContentPage
{
    /*
        Arrumar pag inicial; implementar: multiplicação, Subtração; Vincular a soma no resulado; Botão de apagar um digito apenas.
     */
    private decimal value = 0;
    private decimal _previousValue = 0;
    private string _currentOperation = string.Empty;

    public CalculadoraPage()
    {
        InitializeComponent();
    }

    // Método para lidar com os números
    private void OnButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var buttonText = button.Text;

        // Se o display for "0", substitui pelo número
        if (displayEntry.Text == "0" || "+-*".Contains(displayEntry.Text))
        {
            displayEntry.Text = buttonText;
        }
        else
        {
            // Se não, adiciona o número à string
            displayEntry.Text += buttonText;
        }
    }

    // Método para lidar com as operações (+, -, *, /)
    private void OnOperationClicked(object sender, EventArgs e)
    {
        _previousValue = decimal.Parse(displayEntry.Text);
        value += _previousValue;
        displayEntry.Text = "+"; // Reseta o display para o próximo número
    }

    // Método para calcular o resultado
    private void OnEqualClicked(object sender, EventArgs e)
    {
        _previousValue = decimal.Parse(displayEntry.Text);
        value += _previousValue;
        // Exibe o resultado (Mandar para a página de Calculo da subtração da compra)
        displayEntry.Text = value.ToString();  
        //Mensagem de texto
    }

    // Método para limpar o display
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


    

}