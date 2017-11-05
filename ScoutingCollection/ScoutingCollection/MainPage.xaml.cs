using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScoutingCollection
{
    public partial class MainPage : ContentPage
    {
        MainViewModel mvm;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            Team.Text = null;
            Match.Text = null;
            PitScout.IsEnabled = false;
            MatchScout.IsEnabled = false;
        }
        /*public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            mvm = mainViewModel;
            BindingContext = mvm;
        }*/

        async void PitScout_Clicked(object sender, EventArgs e)
        {
            var psvm = new PitScoutingViewModel();
            var pitscouting = new PitScouting(mvm, psvm);
            pitscouting.BindingContext = psvm;
            await Navigation.PushModalAsync(pitscouting);
        }

        private void MatchScout_Clicked(object sender, EventArgs e)
        {

        }

        private void Team_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry = (Entry)sender;
            Int32 result;
            PitScout.IsEnabled = Int32.TryParse(Team.Text, out result);
        }

        private void Match_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry = (Entry)sender;
            MatchScout.IsEnabled = Int32.TryParse(Match.Text, out int result) &&
                                   Int32.TryParse(Team.Text, out result);
        }

        private void Match_Completed(object sender, EventArgs e)
        {

        }

        private void ReportList_Clicked(object sender, EventArgs e)
        {

        }
    }
}
