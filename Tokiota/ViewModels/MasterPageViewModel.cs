
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using System.Collections.ObjectModel;
using Tokiota.Model;

namespace Tokiota.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {

        public MasterPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            
        }
    }
}
