namespace MMCalculadora;

public partial class ResultadoPage : ContentPage
{
    public decimal Change { get; set; }
	 
    public ResultadoPage(decimal change)
	{
        Change = change;
        InitializeComponent();
        changeLabel.Text = $"Troco: {change:C}";
    }

}