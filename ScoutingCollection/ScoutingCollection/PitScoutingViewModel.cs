using PCLStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace ScoutingCollection
{
    class PitScoutingViewModel : INotifyPropertyChanged
    {
        PitScout report = new PitScout();

        //int team, cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, ground_gear_scale, run_sec, run_scale, strategy, auto_ball, tele_gears, 
            //tele_balls, acc_scale, climb_time;
        //bool fuel, gears, shift_gears, vision, active_gear, ground_gear, ground_ball, baseline, auto_gear, auto_low, tele_low,
            //climb;
        //String team_key, robot_key, drive_train, start_pos, comments, file_name;

        public event PropertyChangedEventHandler PropertyChanged;

        public PitScoutingViewModel()
        {
        }

        public int Team
        {
            set
            {
                if(report.team != value)
                {
                    report.team = value;
                    OnPropertyChanged("Team");
                    SetTeamKey();
                    SetRobotKey();
                    SetFile_Name();
                }
            }
            get
            {
                return report.team;
            }
        }

        public int CIMs_Used
        {
            set
            {
                if (report.cims_used != value)
                {
                    report.cims_used = value;
                    OnPropertyChanged("CIMs_Used");
                }
            }
            get
            {
                return report.cims_used;
            }
        }

        public int Speed_FPS
        {
            set
            {
                if (report.speed_fps != value)
                {
                    report.speed_fps = value;
                    OnPropertyChanged("Speed_FPS");
                }
            }
            get
            {
                return report.speed_fps;
            }
        }

        public int Speed_Scaled
        {
            set
            {
                if (report.speed_scaled != value)
                {
                    report.speed_scaled = value;
                    OnPropertyChanged("Speed_Scaled");
                }
            }
            get
            {
                return report.speed_scaled;
            }
        }

        public int Robot_Wt
        {
            set
            {
                if (report.robot_wt != value)
                {
                    report.robot_wt = value;
                    OnPropertyChanged("Robot_Wt");
                }
            }
            get
            {
                return report.robot_wt;
            }
        }

        public int Ball_Cap
        {
            set
            {
                if (report.ball_cap != value)
                {
                    report.ball_cap = value;
                    OnPropertyChanged("Ball_Cap");
                }
            }
            get
            {
                return report.ball_cap;
            }
        }

        public int Ground_Gear_Scale
        {
            set
            {
                if(report.ground_gear_scale != value)
                {
                    report.ground_gear_scale = value;
                    OnPropertyChanged("Ground_Gear_Scale");
                }
            }
            get
            {
                return report.ground_gear_scale;
            }
        }

        public int Run_Sec
        {
            set
            {
                if (report.run_sec != value)
                {
                    report.run_sec = value;
                    OnPropertyChanged("Run_Sec");
                }
            }
            get
            {
                return report.run_sec;
            }
        }

        public int Run_Scale
        {
            set
            {
                if (report.run_scale != value)
                {
                    report.run_scale = value;
                    OnPropertyChanged("Run_Scale");
                }
            }
            get
            {
                return report.run_scale;
            }
        }

        public string Strategy
        {
            set
            {
                if(report.strategy != ParseStrategy(value) && ParseStrategy(value) != -1)
                {
                    report.strategy = ParseStrategy(value);
                    OnPropertyChanged("Strategy");
                }
            }
            get
            {
                return ParseStrategy(report.strategy);
            }
        }

        public bool Fuel
        {
            set
            {
                if (report.fuel != value)
                {
                    report.fuel = value;
                    OnPropertyChanged("Fuel");
                }
            }
            get
            {
                return report.fuel;
            }
        }

        public bool Gears
        {
            set
            {
                if (report.gears != value)
                {
                    report.gears = value;
                    OnPropertyChanged("Gears");
                }
            }
            get
            {
                return report.gears;
            }
        }

        public bool Shift_Gears
        {
            set
            {
                if (report.shift_gears != value)
                {
                    report.shift_gears = value;
                    OnPropertyChanged("Shift_Gears");
                }
            }
            get
            {
                return report.shift_gears;
            }
        }

        public bool Vision
        {
            set
            {
                if(report.vision != value)
                {
                    report.vision = value;
                    OnPropertyChanged("Vision");
                }
            }
            get
            {
                return report.vision;
            }
        }

        public bool Active_Gear
        {
            set
            {
                if(report.active_gear != value)
                {
                    report.active_gear = value;
                    OnPropertyChanged("Active_Gear");
                }
            }
            get
            {
                return report.active_gear;
            }
        }

        public bool Ground_Gear
        {
            set
            {
                if (report.ground_gear != value)
                {
                    report.ground_gear = value;
                    OnPropertyChanged("Ground_Gear");
                }
            }
            get
            {
                return report.ground_gear;
            }
        }

        public bool Ground_Ball
        {
            set
            {
                if(report.ground_ball != value)
                {
                    report.ground_ball = value;
                    OnPropertyChanged("Ground_Ball");
                }
            }
            get
            {
                return report.ground_ball;
            }
        }

        public bool Baseline
        {
            set
            {
                if (report.baseline != value)
                {
                    report.baseline = value;
                    OnPropertyChanged("Baseline");
                }
            }
            get
            {
                return report.baseline;
            }
        }

        public bool Auto_Gear
        {
            set
            {
                if (report.auto_gear != value)
                {
                    report.auto_gear = value;
                    OnPropertyChanged("Auto");
                }
            }
            get
            {
                return report.auto_gear;
            }
        }

        public String Team_Key
        {
            set
            {
                if (report.team_key != value)
                {
                    report.team_key = value;
                    OnPropertyChanged("Team_Key");
                }
            }
            get
            {
                return report.team_key;
            }
        }

        public String Robot_Key
        {
            set
            {
                if(report.robot_key != value)
                {
                    report.robot_key = value;
                    OnPropertyChanged("Robot_Key");
                }
            }
            get
            {
                return report.robot_key;
            }
        }

        public String Drive_Train
        {
            set
            {
                if (report.drive_train != value)
                {
                    report.drive_train = value;
                    OnPropertyChanged("Drive_Train");
                }
            }
            get
            {
                return report.drive_train;
            }
        }

        public String Start_Pos
        {
            set
            {
                if(report.start_pos != value)
                {
                    report.start_pos = value;
                    OnPropertyChanged("Start_Pos");
                }
            }
            get
            {
                return report.start_pos;
            }
        }

        public String File_Name
        {
            set
            {
                if(report.file_name != value)
                {
                    report.file_name = value;
                    OnPropertyChanged("File_Name");
                }
            }
            get
            {
                return report.file_name;
            }
        }

        private void SetTeamKey()
        {
            this.Team_Key = "frc"+report.team;
        }

        private void SetRobotKey()
        {
            this.Robot_Key = report.team_key + "_2017";
        }

        private void SetFile_Name()
        {
            this.File_Name = "Pit_"+report.team;
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

        public void SaveReport()
        {
            
        }
    }
}
