using GalaSoft.MvvmLight;
using StoreExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.ViewModels
{
    public class CarDetailsViewModel : ViewModelBase
    {
        private Car _selectedCar;
        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                RaisePropertyChanged();
            }
        }

    }
}
