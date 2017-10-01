using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tokiota.Views
{
    public partial class HomeDetailPage : ContentPage
    {
        public HomeDetailPage()
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
