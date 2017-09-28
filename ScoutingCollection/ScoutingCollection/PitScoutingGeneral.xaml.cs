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
            Application.Current.Properties["pitUsesFuel"] = UsesFuel.IsToggled;
            if (UsesFuel.IsToggled)
            {
                BallCap.IsEnabled = true;
            }
            else
                BallCap.IsEnabled = false;
        }

        private void UsesGears_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["pitUsesGears"] = UsesGears.IsToggled;
        }

        private void Shifts_gears_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["pitShifts_gears"] = Shifts_gears.IsToggled;
        }

        private void Vision_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["pitVision"] = Vision.IsToggled;
        }

        private void Active_gear_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["pitActive_gear"] = Active_gear.IsToggled;
        }

        private void Ground_gear_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void DriveTrain_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CIMs_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Speed_fps_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Speed_scale_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BallCap_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}