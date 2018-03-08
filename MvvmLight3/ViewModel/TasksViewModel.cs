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
            this.taskList = new ObservableCollection<Task>();
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 01", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 02", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 03", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 04", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 05", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 06", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 07", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 08", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 09", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 10", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 11", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 12", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 13", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
            taskList.Add(new Task { DueDate = new DateTime(2008, 3, 1, 7, 0, 0), Account = "Acc 14", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vel lectus commodo, interdum lacus vel, tristique nisl. Cras ut sapien at lectus lobortis dictum ac a ex. Sed fringilla gravida nunc. Integer in erat eleifend, sollicitudin tortor at, luctus quam. Vestibulum eget augue purus. Donec quis hendrerit erat, a ornare purus." });
        }

        private Task _selectedItem;
        public Task selectedItem
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
                                Debug.Print(selectedItem.Account.ToString());
                            }
                        }
                    });
                }
                return _navigate;
            }
        }
        public ObservableCollection<Task> taskList { get; set; }

    }
}