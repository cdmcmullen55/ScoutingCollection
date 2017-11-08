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
    public class PitScoutingViewModel : ScoutVM
    {
        //PitScout (report as PitScout);

        //int team, cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, ground_gear_scale, run_sec, run_scale, strategy, auto_ball, tele_gears, 
            //tele_balls, acc_scale, climb_time;
        //bool fuel, gears, shift_gears, vision, active_gear, ground_gear, ground_ball, baseline, auto_gear, auto_low, tele_low,
            //climb;
        //String team_key, robot_key, drive_train, start_pos, comments, file_name;

        public PitScoutingViewModel()
        {
            report = new PitScout(0000);
        }

        public PitScoutingViewModel(int team_number)
        {
            report = new PitScout(team_number);
            TeleGears = "0";
        }

        

        public int CIMs_Used
        {
            set
            {
                if ((report as PitScout).cims_used != value)
                {
                    (report as PitScout).cims_used = value;
                    OnPropertyChanged("CIMs_Used");
                }
            }
            get
            {
                return (report as PitScout).cims_used;
            }
        }

        public int Speed_FPS
        {
            set
            {
                if ((report as PitScout).speed_fps != value)
                {
                    (report as PitScout).speed_fps = value;
                    OnPropertyChanged("Speed_FPS");
                }
            }
            get
            {
                return (report as PitScout).speed_fps;
            }
        }

        public int Speed_Scaled
        {
            set
            {
                if ((report as PitScout).speed_scaled != value)
                {
                    (report as PitScout).speed_scaled = value;
                    OnPropertyChanged("Speed_Scaled");
                }
            }
            get
            {
                return (report as PitScout).speed_scaled;
            }
        }

        public int Robot_Wt
        {
            set
            {
                if ((report as PitScout).robot_wt != value)
                {
                    (report as PitScout).robot_wt = value;
                    OnPropertyChanged("Robot_Wt");
                }
            }
            get
            {
                return (report as PitScout).robot_wt;
            }
        }

        public int Ball_Cap
        {
            set
            {
                if ((report as PitScout).ball_cap != value)
                {
                    (report as PitScout).ball_cap = value;
                    OnPropertyChanged("Ball_Cap");
                }
            }
            get
            {
                return (report as PitScout).ball_cap;
            }
        }

        public int Ground_Gear_Scale
        {
            set
            {
                if((report as PitScout).ground_gear_scale != value)
                {
                    (report as PitScout).ground_gear_scale = value;
                    OnPropertyChanged("Ground_Gear_Scale");
                }
            }
            get
            {
                return (report as PitScout).ground_gear_scale;
            }
        }

        public int AutoBall
        {
            set
            {
                if ((report as PitScout).auto_ball != value)
                {
                    (report as PitScout).auto_ball = value;
                    OnPropertyChanged("Auto_Fuel");
                }
            }
            get
            {
                return (report as PitScout).auto_ball;
            }
        }

        public int Run_Sec
        {
            set
            {
                if ((report as PitScout).run_sec != value)
                {
                    (report as PitScout).run_sec = value;
                    OnPropertyChanged("Run_Sec");
                }
            }
            get
            {
                return (report as PitScout).run_sec;
            }
        }

        public int Run_Scale
        {
            set
            {
                if ((report as PitScout).run_scale != value)
                {
                    (report as PitScout).run_scale = value;
                    OnPropertyChanged("Run_Scale");
                }
            }
            get
            {
                return (report as PitScout).run_scale;
            }
        }

        public string TeleGears
        {
            set
            {
                if ((report as PitScout).tele_gears.ToString() != value && value != null)
                {
                    (report as PitScout).tele_gears = Int32.Parse(value);
                    OnPropertyChanged("TeleGears");
                }
            }
            get
            {
                return ((report as PitScout).tele_gears).ToString();
            }
        }

        public int TeleFuel
        {
            set
            {
                if ((report as PitScout).tele_balls != value)
                {
                    (report as PitScout).tele_balls = value;
                    OnPropertyChanged("TeleFuel");
                }
            }
            get
            {
                return (report as PitScout).tele_balls;
            }
        }

        public int AccScale
        {
            set
            {
                if((report as PitScout).acc_scale != value)
                {
                    (report as PitScout).acc_scale = value;
                    OnPropertyChanged("AccScale");
                }
            }
            get
            {
                return (report as PitScout).acc_scale;
            }
        }

        public int ClimbTime
        {
            set
            {
                if((report as PitScout).climb_time != value)
                {
                    (report as PitScout).climb_time = value;
                    OnPropertyChanged("ClimbTime");
                }
            }
            get
            {
                return (report as PitScout).climb_time;
            }
        }

        public string Strategy
        {
            set
            {
                if((report as PitScout).strategy != ParseStrategy(value) && ParseStrategy(value) != -1)
                {
                    (report as PitScout).strategy = ParseStrategy(value);
                    OnPropertyChanged("Strategy");
                }
            }
            get
            {
                return ParseStrategy((report as PitScout).strategy);
            }
        }

        public bool Fuel
        {
            set
            {
                if ((report as PitScout).fuel != value)
                {
                    (report as PitScout).fuel = value;
                    OnPropertyChanged("Fuel");
                }
            }
            get
            {
                return (report as PitScout).fuel;
            }
        }

        public bool Gears
        {
            set
            {
                if ((report as PitScout).gears != value)
                {
                    (report as PitScout).gears = value;
                    OnPropertyChanged("Gears");
                }
            }
            get
            {
                return (report as PitScout).gears;
            }
        }

        public bool Shift_Gears
        {
            set
            {
                if ((report as PitScout).shift_gears != value)
                {
                    (report as PitScout).shift_gears = value;
                    OnPropertyChanged("Shift_Gears");
                }
            }
            get
            {
                return (report as PitScout).shift_gears;
            }
        }

        public bool Vision
        {
            set
            {
                if((report as PitScout).vision != value)
                {
                    (report as PitScout).vision = value;
                    OnPropertyChanged("Vision");
                }
            }
            get
            {
                return (report as PitScout).vision;
            }
        }

        public bool Active_Gear
        {
            set
            {
                if((report as PitScout).active_gear != value)
                {
                    (report as PitScout).active_gear = value;
                    OnPropertyChanged("Active_Gear");
                }
            }
            get
            {
                return (report as PitScout).active_gear;
            }
        }

        public bool Ground_Gear
        {
            set
            {
                if ((report as PitScout).ground_gear != value)
                {
                    (report as PitScout).ground_gear = value;
                    OnPropertyChanged("Ground_Gear");
                }
            }
            get
            {
                return (report as PitScout).ground_gear;
            }
        }

        public bool Ground_Ball
        {
            set
            {
                if((report as PitScout).ground_ball != value)
                {
                    (report as PitScout).ground_ball = value;
                    OnPropertyChanged("Ground_Ball");
                }
            }
            get
            {
                return (report as PitScout).ground_ball;
            }
        }

        public bool Baseline
        {
            set
            {
                if ((report as PitScout).baseline != value)
                {
                    (report as PitScout).baseline = value;
                    OnPropertyChanged("Baseline");
                }
            }
            get
            {
                return (report as PitScout).baseline;
            }
        }

        public bool AutoGear
        {
            set
            {
                if ((report as PitScout).auto_gear != value)
                {
                    (report as PitScout).auto_gear = value;
                    OnPropertyChanged("Auto_Gear");
                }
            }
            get
            {
                return (report as PitScout).auto_gear;
            }
        }

        public bool AutoLow
        {
            set
            {
                if((report as PitScout).auto_low != value)
                {
                    (report as PitScout).auto_low = value;
                    OnPropertyChanged("AutoLow");
                }
            }
            get
            {
                return (report as PitScout).auto_low;
            }
        }

        public bool TeleLow
        {
            set
            {
                if((report as PitScout).tele_low != value)
                {
                    (report as PitScout).tele_low = value;
                    OnPropertyChanged("TeleLow");
                }
            }
            get
            {
                return (report as PitScout).tele_low;
            }
        }

        public bool Climb
        {
            set
            {
                if((report as PitScout).climb != value)
                {
                    (report as PitScout).climb = value;
                    OnPropertyChanged("Climb");
                }
            }
            get
            {
                return (report as PitScout).climb;
            }
        }
       
        public String Drive_Train
        {
            set
            {
                if ((report as PitScout).drive_train != value)
                {
                    (report as PitScout).drive_train = value;
                    OnPropertyChanged("Drive_Train");
                }
            }
            get
            {
                return (report as PitScout).drive_train;
            }
        }

        public String Start_Pos
        {
            set
            {
                if((report as PitScout).start_pos != value)
                {
                    (report as PitScout).start_pos = value;
                    OnPropertyChanged("Start_Pos");
                }
            }
            get
            {
                return (report as PitScout).start_pos;
            }
        }

        public String File_Name
        {
            set
            {
                if((report as PitScout).file_name != value)
                {
                    (report as PitScout).file_name = value;
                    OnPropertyChanged("File_Name");
                }
            }
            get
            {
                return (report as PitScout).file_name;
            }
        }

        

        private void SetFile_Name()
        {
            this.File_Name = "Pit_"+(report as PitScout).team;
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



    }
}