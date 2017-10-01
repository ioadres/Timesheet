using System;
using Prism.Navigation;

namespace Tokiota.ViewModels
{

    public class BaseNavigationPageViewModel : ViewModelBase
    {
        public BaseNavigationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }

}
