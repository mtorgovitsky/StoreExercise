using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
        public ObservableCollection<Car> CarsToBuy { get; set; }

        public int ItemsCount
        {
            get
            {
                return CarsToBuy.Count;
            }
            private set { }
        }

        public RelayCommand<Car> RemoveFromCard { get; set; }
        public RelayCommand<Car> Buy { get; set; }
        public RelayCommand<Car> Clear { get; set; }

        public ShoppingCardViewModel()
        {

        }
    }
}
