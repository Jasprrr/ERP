/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MvvmLight3.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using MvvmLight3.Common;
using MvvmLight3.Model;
using System;

namespace MvvmLight3.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }

            SetupNavigation();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<TasksViewModel>();
            SimpleIoc.Default.Register<AccountsViewModel>();
        }

        /// <summary>
        /// Gets the main page view model.
        /// </summary>
        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();
        public TasksViewModel HomePageViewModel => SimpleIoc.Default.GetInstance<TasksViewModel>();
        public AccountsViewModel CompaniesViewModel => SimpleIoc.Default.GetInstance<AccountsViewModel>();

        //this, name=> { NameProperty = name}
        //public MainViewModel Main
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<MainViewModel>();
        //    }
        //}

        public TasksViewModel Tasks
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TasksViewModel>();
            }
        }

        public AccountsViewModel AccountsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AccountsViewModel>();
            }
        }

        private static void RegisterServiceProviders()
        {
            SimpleIoc.Default.Register<IMessenger, Messenger>();
            SimpleIoc.Default.Register<MvvmLight3.Common.NavigationService>();
        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigationService();
            navigationService.Configure("TasksView", new Uri("../View/TasksView.xaml", UriKind.Relative));
            navigationService.Configure("AccountsView", new Uri("../View/AccountsView.xaml", UriKind.Relative));

            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);
        }
    }
}