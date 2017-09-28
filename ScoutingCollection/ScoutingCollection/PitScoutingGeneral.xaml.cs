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
        public PitScoutingGeneral()
        {
            InitializeComponent();
        }

        private void FPS_known_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void UsesFuel_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void UsesGears_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Shifts_gears_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Vision_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Active_gear_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Ground_gear_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}