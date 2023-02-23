using AutoAppo_EmanuelH.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AutoAppo_EmanuelH.Views
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