using System.ComponentModel;
using Xamarin.Forms;
using zd6_2BelozerovKlim.ViewModels;

namespace zd6_2BelozerovKlim.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}