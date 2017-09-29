using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScoutingCollection
{
    class PitScoutingViewModel : INotifyPropertyChanged
    {
        int team, cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, run_sec, run_scale, strategy, auto_ball, tele_gears, 
            tele_balls, acc_scale, climb_time;
        bool fuel, gears, shift_gears, vision, active_gear, ground_gear, ground_ball, baseline, auto_gear, auto_low, tele_low,
            climb;
        String team_key, robot_key, drive_train, start_pos, comments;

        public event PropertyChangedEventHandler PropertyChanged;

        public PitScoutingViewModel()
        {
            this.SaveTeamCommand = new Command<string>((key) =>
            {
                Team = Int32.Parse(key);
            });
        }

        public int Team
        {
            set
            {
                if(team != value)
                {
                    team = value;
                    OnPropertyChanged("Team");
                }
            }
            get
            {
                return team;
            }
        }

        public int CimsUsed
        {
            set
            {
                if(cims_used != value)
                {
                    cims_used = value;
                    OnPropertyChanged("CimsUsed");
                }
            }
            get
            {
                return cims_used;
            }
        }

        public ICommand SaveTeamCommand { protected set; get; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
