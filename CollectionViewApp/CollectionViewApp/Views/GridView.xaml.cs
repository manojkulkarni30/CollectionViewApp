using CollectionViewApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridView : ContentPage
    {
        public GridView()
        {
            InitializeComponent();
            BindingContext = new GridViewModel();
        }
    }
}