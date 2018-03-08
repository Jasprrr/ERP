using System.Windows;
using MvvmLight3.ViewModel;

namespace MvvmLight3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }


        private void PopupBox_OnOpened(object sender, RoutedEventArgs e)
        {
        }

        private void PopupBox_OnClosed(object sender, RoutedEventArgs e)
        {
        }
    }
}