using System.Windows;
using GalaSoft.MvvmLight.Threading;
using System.Windows.Controls;

namespace MvvmLight3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
