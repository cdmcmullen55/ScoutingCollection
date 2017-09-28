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