using System;
using Prism.Navigation;

namespace Tokiota.ViewModels
{
    public class HomeDetailPageViewModel : ViewModelBase
    {
		public HomeDetailPageViewModel(INavigationService navigationService
									   )
            : base(navigationService)
        {
			
			Title = "Home";
		}

	}
}
