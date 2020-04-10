using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Covid19_Cases.Models;
using Covid19_Cases.Views;

namespace Covid19_Cases.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Casos Corona Vírus";
        }

        public HomeViewModel(RequestItem _requestItem)
        {
            Title = "Casos Corona Vírus";
            item = _requestItem;
        }

        RequestItem item = new RequestItem();
        public RequestItem Item
        {
            get { return item; }
            set { SetProperty(ref item, value); }
        }

    }
}