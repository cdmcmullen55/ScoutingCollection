﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoutingCollection
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MatchScoutAutoPage : ContentPage
	{
		public MatchScoutAutoPage (MainViewModel mvm)
		{
			InitializeComponent ();
            BindingContext = mvm;
		}

        async void back_Clicked(object sender , EventArgs e)
        {
            if (((BindingContext as MainViewModel).currentReport as MatchVM).Tele)
            {
                ((BindingContext as MainViewModel).currentReport as MatchVM).Tele = false;
                ((BindingContext as MainViewModel).currentReport as MatchVM).setButtonProperties();
            }
            else
                await Navigation.PopModalAsync();
        }

        private void gears_Clicked(object sender, EventArgs e)
        {
            ((BindingContext as MainViewModel).currentReport as MatchVM).gears_selected = true;
            ((BindingContext as MainViewModel).currentReport as MatchVM).RefreshButtons();
        }

        private void pickup_Clicked(object sender, EventArgs e)
        {
            ((BindingContext as MainViewModel).currentReport as MatchVM).gears_selected = false;
            ((BindingContext as MainViewModel).currentReport as MatchVM).RefreshButtons();
        }

        private void continue_Clicked(object sender, EventArgs e)
        {
            ((BindingContext as MainViewModel).currentReport as MatchVM).Tele = true;
            ((BindingContext as MainViewModel).currentReport as MatchVM).setButtonProperties();
        }
    }
}