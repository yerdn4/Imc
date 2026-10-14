using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Imc.Maui.Models;
using System.Windows.Input;

namespace Imc.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _peso;
        [ObservableProperty]
        private string _estatura;
        [ObservableProperty]
        private string _imc;
        [ObservableProperty]
        private string _estadoNutricional;
        
       
        public MainViewModel()
        {
            Limpiar();
           
        }

        [RelayCommand]
        private void Calcular()
        {
            decimal peso;
            decimal estatura;
            bool pesoEsvalido = decimal.TryParse(Peso, out peso);
            bool EstaturaEsvalida = decimal.TryParse(Estatura, out estatura);
            if (pesoEsvalido && EstaturaEsvalida)
            {
                decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
                Imc = imc.ToString("F4");
                EstadoNutricional = CalculadoraImc.SituacionNutricional(imc);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            EstadoNutricional = string.Empty;
        }


        
    }
}
