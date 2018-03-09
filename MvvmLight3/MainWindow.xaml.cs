using System.Windows;


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
        }

        private void PopupBox_OnOpened(object sender, RoutedEventArgs e)
        {
        }

        private void PopupBox_OnClosed(object sender, RoutedEventArgs e)
        {
        }
    }
}