using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Covid19_Cases.Models;
using Covid19_Cases.Views;
using System.Collections.Generic;

namespace Covid19_Cases.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

        public List<Country> listcountry = new List<Country>();
        public List<Country> ListCountry
        {
            get { return listcountry; }
            set { SetProperty(ref listcountry, value); }
        }

        public HomeViewModel()
        {
            Title = "COVID 19";
        }

        public HomeViewModel(RequestItem _requestItem, List<Country> _listCountry)
        {
            Title = "COVID 19";
            item = _requestItem;
            ListCountry = _listCountry;
        }

        RequestItem item = new RequestItem();
        public RequestItem Item
        {
            get { return item; }
            set { SetProperty(ref item, value); }
        }


        string total_casos;
        public string Total_Casos
        {
            get
            {
                if (string.IsNullOrEmpty(item.latest_stat_by_country[0].total_cases))
                {
                    return "Não Informado";
                }

                return item.latest_stat_by_country[0].total_cases + "";

            }
            set { SetProperty(ref total_casos, value); }
        }

        string total_deaths;
        public string Total_Deaths
        {
            get
            {
                if (string.IsNullOrEmpty(item.latest_stat_by_country[0].total_deaths))
                {
                    return "Não Informado";
                }

                return item.latest_stat_by_country[0].total_deaths + "";
            }
            set { SetProperty(ref total_deaths, value); }
        }

        string new_cases;
        public string New_Cases
        {
            get
            {
                if (string.IsNullOrEmpty(item.latest_stat_by_country[0].new_cases))
                {
                    return "Não Informado";
                }

                return item.latest_stat_by_country[0].new_cases + "";
            }
            set { SetProperty(ref new_cases, value); }
        }

        string total_recovered;
        public string Total_Recovered
        {
            get
            {
                if (string.IsNullOrEmpty(item.latest_stat_by_country[0].total_recovered))
                {
                    return "Não Informado";
                }

                return item.latest_stat_by_country[0].total_recovered + "";
            }
            set { SetProperty(ref total_recovered, value); }
        }

        string new_deaths;
        public string New_Deaths
        {
            get
            {
                if (string.IsNullOrEmpty(item.latest_stat_by_country[0].new_deaths))
                {
                    return "Não Informado";
                }

                return item.latest_stat_by_country[0].new_deaths + "";
            }
            set { SetProperty(ref new_deaths, value); }
        }

    }
}