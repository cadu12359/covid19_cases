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


        float total_casos;
        public float Total_Casos
        {
            get { return item.latest_stat_by_country[0].total_cases; }
            set { SetProperty(ref total_casos, value); }
        }

        float total_deaths;
        public float Total_Deaths
        {
            get { return item.latest_stat_by_country[0].total_deaths; }
            set { SetProperty(ref total_deaths, value); }
        }

        float new_cases;
        public float New_Cases
        {
            get { return item.latest_stat_by_country[0].new_cases; }
            set { SetProperty(ref new_cases, value); }
        }

        float total_recovered;
        public float Total_Recovered
        {
            get { return item.latest_stat_by_country[0].total_recovered; }
            set { SetProperty(ref total_recovered, value); }
        }

        float new_deaths;
        public float New_Deaths
        {
            get { return item.latest_stat_by_country[0].new_deaths; }
            set { SetProperty(ref new_deaths, value); }
        }

    }
}