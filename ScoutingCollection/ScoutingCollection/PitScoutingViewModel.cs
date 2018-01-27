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
            isMatch = false;
        }

        public PitScoutingViewModel(int team_number)
        {
            report = new PitScout(team_number);
            isMatch = false;
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

        public int Robot_Weight
        {
            set
            {
                if ((report as PitScout).robot_weight != value)
                {
                    (report as PitScout).robot_weight = value;
                    OnPropertyChanged("Robot_Weight");
                }
            }
            get
            {
                return (report as PitScout).robot_weight;
            }
        }

        public int Num_Cubes
        {
            set
            {
                if ((report as PitScout).num_cubes != value)
                {
                    (report as PitScout).num_cubes = value;
                    OnPropertyChanged("Num_Cubes");
                }
            }
            get
            {
                return (report as PitScout).num_cubes;
            }
        }
        
        public int Climb_Time
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

        public bool Does_Scale
        {
            set
            {
                if ((report as PitScout).does_scale != value)
                {
                    (report as PitScout).does_scale = value;
                    OnPropertyChanged("Does_Scale");
                }
            }
            get
            {
                return (report as PitScout).does_scale;
            }
        }

        public bool Auto_Switch
        {
            set
            {
                if ((report as PitScout).auto_switch != value)
                {
                    (report as PitScout).auto_switch = value;
                    OnPropertyChanged("Auto_Switch");
                }
            }
            get
            {
                return (report as PitScout).auto_switch;
            }
        }

        public bool Auto_Scale
        {
            set
            {
                if ((report as PitScout).auto_scale != value)
                {
                    (report as PitScout).auto_scale = value;
                    OnPropertyChanged("Auto_Scale");
                }
            }
            get
            {
                return (report as PitScout).auto_scale;
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

        public bool Auto_Handles_Rand
        {
            set
            {
                if((report as PitScout).auto_handles_rand != value)
                {
                    (report as PitScout).auto_handles_rand = value;
                    OnPropertyChanged("Auto_Handles_Rand");
                }
            }
            get
            {
                return (report as PitScout).auto_handles_rand;
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

        public string Comments
        {
            set
            {
                if((report as PitScout).comments != value)
                {
                    (report as PitScout).comments = value;
                    OnPropertyChanged("Comments");
                }
            }
            get
            {
                return (report as PitScout).comments;
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

        public override int ParsePosition(string pos)
        {
            if(pos == null)
            {
                return -1;
            }
            if (pos.Equals("Left"))
            {
                return 0;
            }
            if (pos.Equals("Center"))
            {
                return 1;
            }
            if (pos.Equals("Right"))
            {
                return 2;
            }
            else
                return -1;
        }

        public override string ParsePosition(int pos)
        {
            if(pos == 0)
            {
                return "Left";
            }
            if(pos == 1)
            {
                return "Center";
            }
            if (pos == 2)
            {
                return "Right";
            }
            else
                return null;
        }

        private void SetFile_Name()
        {
            this.File_Name = "Pit_"+(report as PitScout).team;
        }
    }
}