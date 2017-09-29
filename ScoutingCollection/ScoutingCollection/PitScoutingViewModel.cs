using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    class PitScoutingViewModel : INotifyPropertyChanged
    {
        int team, cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, run_sec, run_scale, strategy;
        bool fuel, gears, shift_gears, vision, active_gear, ground_gear, ground_ball;

        public event PropertyChangedEventHandler PropertyChanged;

        public PitScoutingViewModel()
        {
            
        }
    }
}
