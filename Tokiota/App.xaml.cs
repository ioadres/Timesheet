using Xamarin.Forms;
using Tokiota.Views;
using Tokiota.ViewModels;
using Prism.Unity;

namespace Tokiota
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected async override void OnInitialized()
		{
			InitializeComponent();

            await NavigationService.NavigateAsync("MasterPage/BaseNavigationPage/HomeDetailPage");
			//await NavigationService.NavigateAsync("MasterPage/BaseNavigationPage/HomePage");
		}


		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<BaseNavigationPage, BaseNavigationPageViewModel>();
            Container.RegisterTypeForNavigation<MasterPage, MasterPageViewModel>();
            Container.RegisterTypeForNavigation<MenuPage, MenuPageViewModel>();
            Container.RegisterTypeForNavigation<HomeDetailPage, HomeDetailPageViewModel>();
		}
	}
}
