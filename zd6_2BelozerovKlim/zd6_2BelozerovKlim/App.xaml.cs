using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using zd6_2BelozerovKlim.Services;
using zd6_2BelozerovKlim.Views;

namespace zd6_2BelozerovKlim
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }
    }
}
