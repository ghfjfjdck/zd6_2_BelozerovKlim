using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace zd6_2BelozerovKlim.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}