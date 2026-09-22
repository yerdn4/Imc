using Imc.Maui.Models;

namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        ImcLabel.Text = string.Empty;
        SituacionNutricionalLabel.Text = string.Empty;
	}

    private void OnCalcularButtonClicked(object sender, EventArgs e)
    {
        decimal peso;
        decimal estatura;
        peso = decimal.Parse(PesoEntry.Text);
        estatura = decimal.Parse(EstaturaEntry.Text);
        decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
        ImcLabel.Text = imc.ToString("F4");
        SituacionNutricionalLabel.Text = CalculadoraImc.SituacionNutricional(imc);
    }

    private void OnLimpiarButtonClicked(object sender, EventArgs e)
    {
        PesoEntry.Text =string.Empty;
        EstaturaEntry.Text =string.Empty;
        ImcLabel.Text=string.Empty;
        SituacionNutricionalLabel.Text=string.Empty;
    }
}