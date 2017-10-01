using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;

namespace Tokiota.Views
{
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            try {
            InitializeComponent();
            } catch(Exception e) {
                Console.Write(e.Message);
            }
			
		}
    }
}
