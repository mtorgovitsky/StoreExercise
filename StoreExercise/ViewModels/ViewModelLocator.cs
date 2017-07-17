using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using StoreExercise.Infra;
using StoreExercise.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<IDataManager, DataManagerService>();
            SimpleIoc.Default.Register<CarDetailsViewModel>();
            SimpleIoc.Default.Register<AddCarViewModel>();
            SimpleIoc.Default.Register<ShoppingCardViewModel>();


            //????????????????????????????????????????
            SimpleIoc.Default.Register<IDialogService, DialogService>();

            var navService = new NavigationService();
            navService.Configure(nameof(MainPage), typeof(MainPage));
            navService.Configure(nameof(CarDetailsView), typeof(CarDetailsView));
            navService.Configure(nameof(ShoppingCardView), typeof(ShoppingCardView));

            SimpleIoc.Default.Register<INavigationService>(() => navService);
        }

        public MainViewModel MainVM
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

        public CarDetailsViewModel CarDetailsVM
        {
            get { return ServiceLocator.Current.GetInstance<CarDetailsViewModel>(); }
        }

        public ShoppingCardViewModel ShoppingCardVM
        {
            get { return ServiceLocator.Current.GetInstance<ShoppingCardViewModel>(); }
        }
    }
}
