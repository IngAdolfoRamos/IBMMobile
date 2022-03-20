using IBMMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IBMMobile.Views
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