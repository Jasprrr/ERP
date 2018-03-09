using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight3.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using System.IO;
using MvvmLight3.Common;

namespace MvvmLight3.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private IFrameNavigationService _navigationService;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService, IFrameNavigationService navigationService)
        {
            _navigationService = navigationService;
            this.navMenu = new ObservableCollection<NavigationItem>();
            navMenu.Add(new NavigationItem { NavTitle = "Home", NavIcon = "Home", NavPage = "AccountsView" });
            navMenu.Add(new NavigationItem { NavTitle = "Tasks", NavIcon = "CalendarCheck", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Customers", NavIcon = "Account", NavPage = "AccountsView" });
            navMenu.Add(new NavigationItem { NavTitle = "Suppliers", NavIcon = "Palette", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Standard Items", NavIcon = "Wrench", NavPage = "AccountsView" });
            navMenu.Add(new NavigationItem { NavTitle = "Quotes", NavIcon = "FormatQuoteClose", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Orders", NavIcon = "Send", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Deliveries", NavIcon = "Truck", NavPage = "AccountsView" });
            navMenu.Add(new NavigationItem { NavTitle = "Invoices", NavIcon = "BookVariant", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Credits", NavIcon = "CreditCard", NavPage = "AccountsView" });
            navMenu.Add(new NavigationItem { NavTitle = "Purchases", NavIcon = "Basket", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Stock", NavIcon = "Widgets", NavPage = "AccountsView" });
            navMenu.Add(new NavigationItem { NavTitle = "NCRs", NavIcon = "Alert", NavPage = "TasksView" });
            navMenu.Add(new NavigationItem { NavTitle = "Reports", NavIcon = "Finance", NavPage = "AccountsView" });
        }        

        private NavigationItem _selectedItem;
        public NavigationItem selectedItem
        {
            get { return _selectedItem; }
            set { if (_selectedItem != value) { _selectedItem = value; RaisePropertyChanged("selectedItem"); } }
        }

        private RelayCommand _navigate;
        public RelayCommand Navigate
        {
            get {
                if (_navigate == null)
                {
                    _navigate = new RelayCommand(() => 
                    {
                        if (_navigate != null)
                        {
                            if (_navigate != null) {
                                _navigationService.NavigateTo(selectedItem.NavPage.ToString());
                                
                                Cleanup();
                            }
                        }
                    });
                } return _navigate;
            }
        }

        public void NavigateChild()
        {

        }

        public ObservableCollection<NavigationItem> navMenu { get; set; }

        private Uri _mainFrame;
        public Uri mainFrame
        {
            get { return _mainFrame; }
            set { if (_mainFrame != value) { _mainFrame = value; RaisePropertyChanged("mainFrame"); } }
        }


        public override void Cleanup()
        {
            // Clean up if needed

            base.Cleanup();
        }
    }
}