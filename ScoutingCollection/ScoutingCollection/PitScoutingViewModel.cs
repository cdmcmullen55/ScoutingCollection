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
        }

        public int Team
        {
            set
            {
                if(team != value)
                {
                    team = value;
                    OnPropertyChanged("Team");
                    SetTeamKey();
                    SetRobotKey();
                }
            }
            get
            {
                return team;
            }
        }

        public int CIMs_Used
        {
            set
            {
                if (cims_used != value)
                {
                    cims_used = value;
                    OnPropertyChanged("CIMs_Used");
                }
            }
            get
            {
                return cims_used;
            }
        }

        public int Speed_FPS
        {
            set
            {
                if (speed_fps != value)
                {
                    speed_fps = value;
                    OnPropertyChanged("Speed_FPS");
                }
            }
            get
            {
                return speed_fps;
            }
        }

        public int Speed_Scaled
        {
            set
            {
                if (speed_scaled != value)
                {
                    speed_scaled = value;
                    OnPropertyChanged("Speed_Scaled");
                }
            }
            get
            {
                return speed_scaled;
            }
        }

        public int Robot_Wt
        {
            set
            {
                if (robot_wt != value)
                {
                    robot_wt = value;
                    OnPropertyChanged("Robot_Wt");
                }
            }
            get
            {
                return robot_wt;
            }
        }

        public bool Fuel
        {
            set
            {
                if (fuel != value)
                {
                    fuel = value;
                    OnPropertyChanged("Fuel");
                }
            }
            get
            {
                return fuel;
            }
        }

        public bool Gears
        {
            set
            {
                if (gears != value)
                {
                    gears = value;
                    OnPropertyChanged("Gears");
                }
            }
            get
            {
                return gears;
            }
        }

        public String Team_Key
        {
            set
            {
                if (team_key != value)
                {
                    team_key = value;
                    OnPropertyChanged("Team_Key");
                }
            }
            get
            {
                return team_key;
            }
        }

        public String Robot_Key
        {
            set
            {
                if(robot_key != value)
                {
                    robot_key = value;
                    OnPropertyChanged("Robot_Key");
                }
            }
            get
            {
                return robot_key;
            }
        }

        public String Drive_Train
        {
            set
            {
                if (drive_train != value)
                {
                    drive_train = value;
                    OnPropertyChanged("Drive_Train");
                }
            }
            get
            {
                return drive_train;
            }
        }

        private void SetTeamKey()
        {
            this.Team_Key = "frc"+team;
        }

        private void SetRobotKey()
        {
            this.Robot_Key = team_key + "_2017";
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
