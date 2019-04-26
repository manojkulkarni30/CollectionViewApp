using CollectionViewApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicPage : ContentPage
    {
        public BasicPage()
        {
            InitializeComponent();
            BindingContext = new BasicViewModel();
        }
    }
}