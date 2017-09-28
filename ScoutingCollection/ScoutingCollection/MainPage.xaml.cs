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
        public MainPage()
        {
            InitializeComponent();

            Team.Text = null;
            Match.Text = null;
            PitScout.IsEnabled = false;
            MatchScout.IsEnabled = false;
        }

        async void PitScout_Clicked(object sender, EventArgs e) => await Navigation.PushModalAsync(new PitScouting
        {
            BindingContext = Team
        });

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
    }
}
