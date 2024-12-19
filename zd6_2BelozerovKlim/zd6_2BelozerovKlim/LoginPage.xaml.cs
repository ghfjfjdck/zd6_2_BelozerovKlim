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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == "ects" && password == "ects2024")
            {
                Application.Current.MainPage = new MainTabbedPage();
            }
            else
            {
                await DisplayAlert("Ошибка", "Неверный логин или пароль", "OK");
            }
        }
    }
}