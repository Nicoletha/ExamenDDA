using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_DDA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double num1) && double.TryParse(numero2.Text, out double num2))
            {
                double resultado = num1 + num2;
                resultadoLabel.Text = $"Resultado: {resultado}";
            }
        }

        private void Restar(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double num1) && double.TryParse(numero2.Text, out double num2))
            {
                double resultado = num1 - num2;
                resultadoLabel.Text = $"Resultado: {resultado}";
            }
        }

        private void Multiplicar(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double num1) && double.TryParse(numero2.Text, out double num2))
            {
                double resultado = num1 * num2;
                resultadoLabel.Text = $"Resultado: {resultado}";
            }
        }

        private void Dividir(object sender, EventArgs e)
        {
            if (double.TryParse(numero1.Text, out double num1) && double.TryParse(numero2.Text, out double num2))
            {
                if (num2 != 0)
                {
                    double resultado = num1 / num2;
                    resultadoLabel.Text = $"Resultado: {resultado}";
                }
                else
                {
                    resultadoLabel.Text = "No se puede dividir por cero.";
                }
            }
        }
    } 
}




