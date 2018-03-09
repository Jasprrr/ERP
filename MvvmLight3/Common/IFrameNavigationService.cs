using GalaSoft.MvvmLight.Views;

namespace MvvmLight3.Common
{
    public interface IFrameNavigationService : INavigationService
    {
        object Parameter { get; }
    }
}
