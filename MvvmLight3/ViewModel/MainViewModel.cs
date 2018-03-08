using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight3.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            this.navMenu = new ObservableCollection<NavigationItem>();
            navMenu.Add(new NavigationItem { NavTitle = "Home", NavIcon = "Home", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Tasks", NavIcon = "CalendarCheck", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Customers", NavIcon = "Account", NavPage = "View/AccountsView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Suppliers", NavIcon = "Palette", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Standard Items", NavIcon = "Wrench", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Quotes", NavIcon = "FormatQuoteClose", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Orders", NavIcon = "Send", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Deliveries", NavIcon = "Truck", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Invoices", NavIcon = "BookVariant", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Credits", NavIcon = "CreditCard", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Purchases", NavIcon = "Basket", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Stock", NavIcon = "Widgets", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "NCRs", NavIcon = "Alert", NavPage = "View/TasksView.xaml" });
            navMenu.Add(new NavigationItem { NavTitle = "Reports", NavIcon = "Finance", NavPage = "View/TasksView.xaml" });
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
                                this.mainFrame = new Uri(selectedItem.NavPage.ToString(), UriKind.Relative);
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