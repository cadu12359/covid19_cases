﻿using System;
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
        List<Country> listCountry;

        public HomePage()
        {
            InitializeComponent();

            try
            {
                requestItem = APiService.GetData("Brazil").GetAwaiter().GetResult();
                listCountry = APiService.GetDataCountry().GetAwaiter().GetResult();

                if (!string.IsNullOrEmpty(requestItem.country) && listCountry.Count > 1)
                {
                    BindingContext = viewModel = new HomeViewModel(requestItem, listCountry);
                }
                else
                {
                    BindingContext = viewModel = new HomeViewModel();
                }
            }
            catch (Exception e)
            {
                DisplayAlert("Error", e.Message, "OK");
            }
            
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            Country selectedItem = (Country)picker.SelectedItem;

            requestItem = APiService.GetData(selectedItem.name).GetAwaiter().GetResult();

            if (!string.IsNullOrEmpty(requestItem.country))
            {
                BindingContext = viewModel = new HomeViewModel(requestItem, listCountry);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}