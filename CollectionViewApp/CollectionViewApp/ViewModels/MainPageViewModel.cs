using CollectionViewApp.Views;
using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CarouselPage = CollectionViewApp.Views.CarouselPage;

namespace CollectionViewApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Commands

        private ICommand _basicCommand;
        public ICommand BasicCommand => _basicCommand ?? (_basicCommand = new Command(async () => await ExecuteBasicCommandAsync()));

        private ICommand _carouselCommand;
        public ICommand CarouselCommand => _carouselCommand ?? (_carouselCommand = new Command(async () => await ExecuteCarouselCommandAsync()));

        private ICommand _gridCommand;
        public ICommand GridCommand => _gridCommand ?? (_gridCommand = new Command(async () => await ExecuteGridCommandAsync()));

        private ICommand _emptyCommand;
        public ICommand EmptyCommand => _emptyCommand ?? (_emptyCommand = new Command(async () => await ExecuteEmptyCommandAsync()));

        #endregion

        #region Methods

        private async Task ExecuteBasicCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BasicPage());
        }

        private async Task ExecuteCarouselCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CarouselPage());
        }

        private async Task ExecuteGridCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new GridView());
        }

        private async Task ExecuteEmptyCommandAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmptyPage());
        }

        #endregion
    }
}
