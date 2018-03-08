using GalaSoft.MvvmLight;
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
        /// <summary>
        /// Initializes a new instance of the AccountsViewModel class.
        /// </summary>
        public AccountsViewModel()
        {
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