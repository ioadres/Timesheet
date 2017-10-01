using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Tokiota.ViewModels;

namespace Tokiota.Views
{
    public partial class MenuPage : ContentPage
    {

        public MenuPageViewModel ViewModel
		{
			get { return BindingContext as MenuPageViewModel; }
		}

        public MenuPage()
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
