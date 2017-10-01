using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;

namespace Tokiota.Views
{
	public partial class BaseNavigationPage : NavigationPage, INavigationPageOptions
	{
		public bool ClearNavigationStackOnNavigation
		{
			get { return true; }
		}

		public BaseNavigationPage()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception e)
			{
				Console.Write(e.Message);
			}
		}
	}
}
