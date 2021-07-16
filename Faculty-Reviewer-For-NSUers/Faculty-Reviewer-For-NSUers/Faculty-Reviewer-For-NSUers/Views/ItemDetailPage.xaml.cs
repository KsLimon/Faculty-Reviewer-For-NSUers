using Faculty_Reviewer_For_NSUers.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Faculty_Reviewer_For_NSUers.Views
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