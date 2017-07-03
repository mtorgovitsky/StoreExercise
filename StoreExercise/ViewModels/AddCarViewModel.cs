using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using StoreExercise.Infra;
using StoreExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoreExercise.ViewModels
{
    public class AddCarViewModel : ViewModelBase
    {
        private readonly IDataManager _dataManager;

        public Car CurrentCar { get; set; }
        public ICommand AddCarCommand { get; set; }

        public AddCarViewModel()
        {
            CurrentCar = new Car();

            AddCarCommand = new RelayCommand(() =>
            {

            });
        }
    }
}
