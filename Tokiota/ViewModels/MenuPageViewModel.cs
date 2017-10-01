using System;
using System.Collections.ObjectModel;
using Prism.Navigation;
using Tokiota.Model;

namespace Tokiota.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
		public ObservableCollection<MenuItem> MenuTimeSheet { get; set; }
		public ObservableCollection<MenuItem> MenuConfiguration { get; set; }

		private string _titleMenuTimesheet;
		public string TitleMenuTimesheet
		{
			get { return _titleMenuTimesheet; }
			set { SetProperty(ref _titleMenuTimesheet, value); }
		}

		private string _titleMenuConfiguration;
		public string TitleMenuConfiguration
		{
			get { return _titleMenuConfiguration; }
			set { SetProperty(ref _titleMenuConfiguration, value); }
		}


		public MenuPageViewModel(
			INavigationService navigationService
			
		)
            :base(navigationService)

        {
            Title = "Quotes";
			TitleMenuTimesheet = "Timesheet";
			TitleMenuConfiguration = "Configuración";
			LoadMenuTimeSheet();
			LoadMenuConfiguration();
        }


		public void LoadMenuTimeSheet()
		{
			MenuTimeSheet = new ObservableCollection<MenuItem>();

			MenuTimeSheet.Add(new MenuItem()
			{
				Icon = "ic_calendar",
				Title = "Home",
				PageName = "HomePage"
			});

			MenuTimeSheet.Add(new MenuItem()
			{
				Icon = "ic_calendar",
				Title = "Imputar",
				PageName = "HomePage"
			});

			MenuTimeSheet.Add(new MenuItem()
			{
				Icon = "ic_calendar",
				Title = "Review",
				PageName = "HomePage"
			});

		}

		public void LoadMenuConfiguration()
		{
			MenuConfiguration = new ObservableCollection<MenuItem>();

			MenuConfiguration.Add(new MenuItem()
			{
				Icon = "ic_calendar",
				Title = "Perfil",
				PageName = "HomePage"
			});

			MenuConfiguration.Add(new MenuItem()
			{
				Icon = "ic_calendar",
				Title = "Notificacion",
				PageName = "HomePage"
			});

		}
    }
}
