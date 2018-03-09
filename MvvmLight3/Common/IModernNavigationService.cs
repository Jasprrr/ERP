using GalaSoft.MvvmLight.Views;

namespace MvvmLight3.Common
{
    /// <summary>
    /// The ModernNavigationService interface.
    /// </summary>
    public interface IModernNavigationService : INavigationService
    {
        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <value>
        /// The parameter.
        /// </value>
        object Parameter { get; }
    }
}