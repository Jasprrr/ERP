using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight3.Model;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MvvmLight3.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TasksViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the TasksViewModel class.
        /// </summary>
        public TasksViewModel()
        {
            this.tasks = new ObservableCollection<Task>();
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 01", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 02", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 03", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 04", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 05", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 06", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 07", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 08", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 09", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 10", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 11", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 12", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 13", Description = "Task to do" });
            tasks.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 14", Description = "Task to do" });
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
                                Debug.Print(selectedItem.NavPage.ToString());
                            }
                        }
                    });
                }
                return _navigate;
            }
        }
        public ObservableCollection<Task> tasks { get; set; }

    }
}