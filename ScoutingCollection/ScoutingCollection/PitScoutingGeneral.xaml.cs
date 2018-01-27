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
    public partial class PitScoutingGeneral : ContentPage
    {
        public static String team_number;

        public PitScoutingGeneral()
        {
            InitializeComponent();            
        }

        private void FPS_known_Toggled(object sender, ToggledEventArgs e)
        {
            Speed_fps.IsEnabled = FPS_known.IsToggled;
            Speed_scale.IsEnabled = !FPS_known.IsToggled;
        }
    }
}