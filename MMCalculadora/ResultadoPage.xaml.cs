using System.Globalization;

namespace MMCalculadora;

public partial class ResultadoPage : ContentPage
{
    public decimal Change { get; set; }
	 
    public ResultadoPage(decimal change)
	{
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        Change = change;
        InitializeComponent();
        changeLabel.Text = $"Troco: {change:C}";
    }

}