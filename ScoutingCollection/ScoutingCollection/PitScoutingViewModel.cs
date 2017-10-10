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
        int team, cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, ground_gear_scale, run_sec, run_scale, strategy, auto_ball, tele_gears, 
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

        public int Ball_Cap
        {
            set
            {
                if (ball_cap != value)
                {
                    ball_cap = value;
                    OnPropertyChanged("Ball_Cap");
                }
            }
            get
            {
                return ball_cap;
            }
        }

        public int Ground_Gear_Scale
        {
            set
            {
                if(ground_gear_scale != value)
                {
                    ground_gear_scale = value;
                    OnPropertyChanged("Ground_Gear_Scale");
                }
            }
            get
            {
                return ground_gear_scale;
            }
        }

        public int Run_Sec
        {
            set
            {
                if (run_sec != value)
                {
                    run_sec = value;
                    OnPropertyChanged("Run_Sec");
                }
            }
            get
            {
                return run_sec;
            }
        }

        public int Run_Scale
        {
            set
            {
                if (run_scale != value)
                {
                    run_scale = value;
                    OnPropertyChanged("Run_Scale");
                }
            }
            get
            {
                return run_scale;
            }
        }

        public string Strategy
        {
            set
            {
                if(strategy != ParseStrategy(value) && ParseStrategy(value) != -1)
                {
                    strategy = ParseStrategy(value);
                    OnPropertyChanged("Strategy");
                }
            }
            get
            {
                return ParseStrategy(strategy);
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

        public bool Shift_Gears
        {
            set
            {
                if (shift_gears != value)
                {
                    shift_gears = value;
                    OnPropertyChanged("Shift_Gears");
                }
            }
            get
            {
                return shift_gears;
            }
        }

        public bool Vision
        {
            set
            {
                if(vision != value)
                {
                    vision = value;
                    OnPropertyChanged("Vision");
                }
            }
            get
            {
                return vision;
            }
        }

        public bool Active_Gear
        {
            set
            {
                if(active_gear != value)
                {
                    active_gear = value;
                    OnPropertyChanged("Active_Gear");
                }
            }
            get
            {
                return active_gear;
            }
        }

        public bool Ground_Gear
        {
            set
            {
                if (ground_gear != value)
                {
                    ground_gear = value;
                    OnPropertyChanged("Ground_Gear");
                }
            }
            get
            {
                return ground_gear;
            }
        }

        public bool Ground_Ball
        {
            set
            {
                if(ground_ball != value)
                {
                    ground_ball = value;
                    OnPropertyChanged("Ground_Ball");
                }
            }
            get
            {
                return ground_ball;
            }
        }

        public bool Baseline
        {
            set
            {
                if(baseline != value)
                {
                    baseline = value;
                    OnPropertyChanged("Baseline");
                }
            }
            get
            {
                return baseline;
            }
        }

        public bool Auto_Gear
        {
            set
            {
                if (auto_gear != value)
                {
                    auto_gear = value;
                    OnPropertyChanged("Auto");
                }
            }
            get
            {
                return auto_gear;
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

        public String Start_Pos
        {
            set
            {
                if(start_pos != value)
                {
                    start_pos = value;
                    OnPropertyChanged("Start_Pos");
                }
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

        private int ParseStrategy(string strat)
        {
            if (strat == null)
                return -1;
            if (strat.Equals("Offense"))
                return 0;
            else if (strat.Equals("Defense"))
                return 1;
            else
                return 2;
        }

        private string ParseStrategy(int strat)
        {
            if (strat == 0)
                return "Offense";
            else if (strat == 1)
                return "Defense";
            else
                return "Both";
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
