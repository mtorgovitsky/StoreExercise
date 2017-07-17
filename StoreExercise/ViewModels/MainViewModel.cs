﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using StoreExercise.Infra;
using StoreExercise.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoreExercise.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataManager _dataManager;
        private readonly INavigationService _navService;

        public ObservableCollection<Car> Cars { get; set; }
        public ICommand AddToCard { get; set; }
        public RelayCommand<Car> CarDetailsCommand { get; set; }

        public MainViewModel(IDataManager dataManager, INavigationService navService)
        {
            _dataManager = dataManager;
            _navService = navService;
           

            Cars = new ObservableCollection<Car>(_dataManager.GetAll());
            RaisePropertyChanged(nameof(Cars));

            CarDetailsCommand = new RelayCommand<Car>((c) =>
            {
                _navService.NavigateTo("CarDetailsView", c);
            });

            #region Mock For Initial Car Collection - Remove After testing

            Uri imgURI = new Uri("ms-appx://StoreExercise/Assets/sabra.jpg");
            for (int i = 0; i < 3; i++)
            {
                Cars.Add(new Car
                {
                    Model = $"0{i} Model",
                    Firm = $"0{i} Firm",
                    Id = i,
                    Price = 69000,
                    Year = 2014 + i,
                    ImageURI = imgURI.ToString()
                });
            }
            #endregion
        }
    }
}
