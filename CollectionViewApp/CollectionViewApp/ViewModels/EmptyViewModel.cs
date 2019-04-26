using CollectionViewApp.Models;
using MvvmHelpers;

namespace CollectionViewApp.ViewModels
{
    public class EmptyViewModel : BaseViewModel
    {
        #region Public Properties

        private ObservableRangeCollection<Monkey> _monkeys;
        public ObservableRangeCollection<Monkey> Monkeys
        {
            get => _monkeys;
            set => SetProperty(ref _monkeys, value);
        }

        #endregion

        #region Constructor

        public EmptyViewModel()
        {
            Monkeys = new ObservableRangeCollection<Monkey>();
        }

        #endregion
    }
}
