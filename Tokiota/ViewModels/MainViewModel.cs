using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace Tokiota.ViewModels
{
	public class MainViewModel
	{
        private NavigationService navigationService;

        public MainViewModel()
		{		
            navigationService = new NavigationService();
           
		}

		#region Properties
		
		#endregion

		#region Commands

		public ICommand GoToCommand
		{
			get { return new RelayCommand<string>(GoTo); }
		}

		private void GoTo(string pageName)
		{			
			navigationService.NavigateTo(pageName);
		}
	

		#endregion

		

	}

}
