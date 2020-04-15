using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Covid19_Cases.Models;
using Covid19_Cases.Views;
using Covid19_Cases.ViewModels;
using Covid19_Cases.Services;

namespace Covid19_Cases.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;
        RequestItem requestItem;

        public HomePage()
        {
            InitializeComponent();

            requestItem = APiService.GetData("Brazil");
            var requestItem1 = APiService.GetDataCountry();

            if (!string.IsNullOrEmpty(requestItem.country))
            {
                BindingContext = viewModel = new HomeViewModel(requestItem);
            }
            else
            {
                BindingContext = viewModel = new HomeViewModel();
            }
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}