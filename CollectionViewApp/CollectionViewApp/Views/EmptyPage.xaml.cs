using CollectionViewApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmptyPage : ContentPage
    {
        public EmptyPage()
        {
            InitializeComponent();
            BindingContext = new EmptyViewModel();
        }
    }
}