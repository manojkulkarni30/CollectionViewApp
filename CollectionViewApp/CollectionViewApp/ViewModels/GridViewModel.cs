using CollectionViewApp.Models;
using CollectionViewApp.Services;
using MvvmHelpers;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewApp.ViewModels
{
    public class GridViewModel : BaseViewModel
    {
        #region Fields  

        private readonly MonkeyService _monkeyService;

        #endregion

        #region Public Properties

        private ObservableRangeCollection<Monkey> _monkeys;
        public ObservableRangeCollection<Monkey> Monkeys
        {
            get => _monkeys;
            set => SetProperty(ref _monkeys, value);
        }


        #endregion

        #region Commands

        private ICommand _loadDataCommand;
        public ICommand LoadDataCommand => _loadDataCommand ?? (_loadDataCommand = new Command(async () => await GetMonkeysListAsync()));

        #endregion

        #region Constructor

        public GridViewModel()
        {
            Monkeys = new ObservableRangeCollection<Monkey>();
            _monkeyService = new MonkeyService();
        }

        #endregion

        #region Methods

        private async Task GetMonkeysListAsync()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var monkeys = await _monkeyService.GetAllMonkeysAsync();
                if (monkeys != null && monkeys.Any())
                    Monkeys.AddRange(monkeys);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        #endregion
    }
}
