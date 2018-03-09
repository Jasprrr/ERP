using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MvvmLight3.Model;
using System.Collections.ObjectModel;

namespace MvvmLight3.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class AccountsViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        private RelayCommand _navigate;
        public RelayCommand Navigate
        {
            get
            {
                if (_navigate == null)
                {
                    _navigate = new RelayCommand(() =>
                    {
                        if (_navigate != null)
                        {
                            if (_navigate != null)
                            {
                                Messenger.Default.Send(new NotificationMessage("test"));
                            }
                        }
                    });
                }
                return _navigate;
            }
        }

        /// <summary>
        /// Initializes a new instance of the AccountsViewModel class.
        /// </summary>
        public AccountsViewModel(IDataService dataService)
        {
            //_dataService = dataService;
            //_dataService.GetData(
            //    (item, error) =>
            //    {
            //        if (error != null)
            //        {
            //            // Report error here
            //            return;
            //        }
            //    });
            accountList = new ObservableCollection<Account>();
            accountList.Add(new Account() { Name = "Tim Co.", Email = "tim@tim.co", Telephone = "0800 000 001" });
            accountList.Add(new Account() { Name = "Bob Co.", Email = "bob@bob.co", Telephone = "0800 000 002" });
            accountList.Add(new Account() { Name = "Rob Co.", Email = "rob@rob.co", Telephone = "0800 000 003" });
            accountList.Add(new Account() { Name = "Jim Co.", Email = "jim@jim.co", Telephone = "0800 000 004" });
            accountList.Add(new Account() { Name = "Sam Co.", Email = "sam@sam.co", Telephone = "0800 000 005" });
        }

        public ObservableCollection<Account> accountList { get; set; }
    }
}