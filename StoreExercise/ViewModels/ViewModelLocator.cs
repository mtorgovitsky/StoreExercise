using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using StoreExercise.Infra;
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
            SimpleIoc.Default.Register<AddCarViewModel>();

            SimpleIoc.Default.Register<IDataManager, DataManagerService>();
            SimpleIoc.Default.Register<IDialogService, DialogService>();

            var navService = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navService);
        }

        public MainViewModel MainVM
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }
    }
}
