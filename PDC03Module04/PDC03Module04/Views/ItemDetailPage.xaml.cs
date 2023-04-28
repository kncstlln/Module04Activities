using PDC03Module04.ViewModels;
using Xamarin.Forms;

namespace PDC03Module04.Views
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