using System;
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
                baseline.IsEnabled = true;
            }
            else
                await Navigation.PopModalAsync();
        }

        private void place_Clicked(object sender, EventArgs e)
        {
            ((BindingContext as MainViewModel).currentReport as MatchVM).place_selected = true;
            ((BindingContext as MainViewModel).currentReport as MatchVM).setButtonProperties();
            Grid.SetColumn(ButtonOne, 0);
            Grid.SetColumnSpan(ButtonOne, 3);
            Grid.SetColumn(ButtonTwo, 3);
            Grid.SetColumnSpan(ButtonTwo, 3);
            Grid.SetColumn(ButtonThree, 6);
            Grid.SetColumnSpan(ButtonThree, 3);
            Grid.SetColumn(ButtonFour, 9);
            Grid.SetColumnSpan(ButtonFour, 3);
        }

        private void pickup_Clicked(object sender, EventArgs e)
        {
            ((BindingContext as MainViewModel).currentReport as MatchVM).place_selected = false;
            ((BindingContext as MainViewModel).currentReport as MatchVM).setButtonProperties();
            Grid.SetColumn(ButtonOne, 0);
            Grid.SetColumnSpan(ButtonOne, 4);
            Grid.SetColumnSpan(ButtonTwo, 4);
            Grid.SetColumnSpan(ButtonTwo, 4);
            Grid.SetColumn(ButtonThree, 8);
            Grid.SetColumnSpan(ButtonThree, 4);
            ButtonFour.IsVisible = false;
        }

        async void continue_Clicked(object sender, EventArgs e)
        {
            if (((BindingContext as MainViewModel).currentReport as MatchVM).Tele)
            {
                var finish = await DisplayAlert("Finish?", "You will not be able to make changes after continuing.", "Finish", 
                    "Cancel");
                if (finish)
                {
                    var postmatchpage = new PostMatchScoutPage((BindingContext as MainViewModel), this);
                    await Navigation.PushModalAsync(postmatchpage);
                }
                else
                    return;
            }
            else
            {
                ((BindingContext as MainViewModel).currentReport as MatchVM).Tele = true;
                ((BindingContext as MainViewModel).currentReport as MatchVM).setButtonProperties();
                baseline.IsEnabled = false;
            }
        }

        private void baseline_Clicked(object sender, EventArgs e)
        {
            ((BindingContext as MainViewModel).currentReport as MatchVM).Baseline = true;
        }
    }
}