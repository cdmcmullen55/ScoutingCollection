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
            UsesFuel.IsToggled = true;
            UsesGears.IsToggled = true;
            Speed_fps.IsEnabled = FPS_known.IsToggled;
            Speed_scale.IsEnabled = !FPS_known.IsToggled;
            BallCap.IsEnabled = UsesFuel.IsToggled;
            Ground_gear.IsEnabled = UsesGears.IsToggled;
            Active_gear.IsEnabled = UsesGears.IsToggled;
            Ground_gear_scale.IsEnabled = Ground_gear.IsToggled;
            Gear_time_known.IsEnabled = UsesGears.IsToggled;
            Gear_run_sec.IsEnabled = Gear_time_known.IsToggled;
            Gear_run_scale.IsEnabled = !Gear_time_known.IsToggled;
            Ground_ball_pickup.IsEnabled = UsesFuel.IsToggled;
        }

        private void FPS_known_Toggled(object sender, ToggledEventArgs e)
        {
            Speed_fps.IsEnabled = FPS_known.IsToggled;
            Speed_scale.IsEnabled = !FPS_known.IsToggled;
        }

        private void UsesFuel_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["pitUsesFuel"] = UsesFuel.IsToggled;
            BallCap.IsEnabled = UsesFuel.IsToggled;
            Ground_ball_pickup.IsEnabled = UsesFuel.IsToggled;
        }

        private void UsesGears_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["pitUsesGears"] = UsesGears.IsToggled;
            Active_gear.IsEnabled = UsesGears.IsToggled;
            Ground_gear.IsEnabled = UsesGears.IsToggled;
            Gear_time_known.IsEnabled = UsesGears.IsToggled;
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
            Application.Current.Properties["pitGround_gear"] = Ground_gear.IsToggled;
            Ground_gear_scale.IsEnabled = Ground_gear.IsToggled;
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

        private void Ground_scale_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Gear_time_known_Toggled(object sender, ToggledEventArgs e)
        {
            Gear_run_sec.IsEnabled = Gear_time_known.IsToggled;
            Gear_run_scale.IsEnabled = !Gear_time_known.IsToggled;
        }

        private void Gear_run_sec_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Gear_run_scale_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Ground_ball_pickup_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Strategy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}