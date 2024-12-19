using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_2BelozerovKlim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExchangeRatesPage : ContentPage
    {
        public ExchangeRatesPage()
        {
            InitializeComponent();
            CurrentDateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
            UsdRateLabel.Text = "80.000"; // Пример курса USD
            EurRateLabel.Text = "86.000"; // Пример курса EUR
        }
    }
}