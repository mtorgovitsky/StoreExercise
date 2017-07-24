using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using StoreExercise.Infra;
using StoreExercise.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.ViewModels
{
    public class ShoppingCardViewModel : ViewModelBase
    {
        public ObservableCollection<ShoppingItem> ItemsToBuy { get; set; }

        private readonly IDataManager _dataManager;

        public int ItemsCount
        {
            get
            {
                return ItemsToBuy.Count;
            }
            private set { }
        }

        public RelayCommand<ShoppingItem> RemoveFromCard { get; set; }
        public RelayCommand<ShoppingItem> Buy { get; set; }
        public RelayCommand<ShoppingItem> Clear { get; set; }

        public ShoppingCardViewModel(IDataManager dataManager)
        {
            _dataManager = dataManager;

            ItemsToBuy = new ObservableCollection<ShoppingItem>(_dataManager.GetShoppingCard());
            RaisePropertyChanged(nameof(ItemsToBuy));

            RemoveFromCard = new RelayCommand<ShoppingItem>((c) =>
            {
                if (_dataManager.RemoveFromCard(c))
                {
                    ItemsToBuy.Remove(c);
                }
            });
        }
    }
}
