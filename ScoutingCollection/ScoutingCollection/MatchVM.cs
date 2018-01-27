using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScoutingCollection
{
    public class MatchVM : ScoutVM
    {
        public bool gears_selected, tele;

        public Button load_gear, cent_gear, boil_gear, drop_gear, grnd_pckp, load_pckp;

        public ICommand IncrementCommand { private set; get; }

        public MatchVM(int team_num, int match_num)
        {
            report = new MatchScout(team_num, match_num);
            gears_selected = true;
            tele = false;
            isMatch = true;
            IncrementCommand = new Command<string>(Increment);
            setButtonProperties();
        }

        public int MatchNumber
        {
            set
            {
                if ((report as MatchScout).match_number != value)
                {
                    (report as MatchScout).match_number = value;
                    TMKey = Team + "_" + MatchNumber + "_" + CompKey;
                    OnPropertyChanged("MatchNumber");
                }
            }
            get
            {
                return (report as MatchScout).match_number;
            }
        }

        

        public int Auto_Switch
        {
            set
            {
                if ((report as MatchScout).auto_switch != value)
                {
                    (report as MatchScout).auto_switch = value;
                    OnPropertyChanged("Auto_Switch");
                }
            }
            get
            {
                return (report as MatchScout).auto_switch;
            }
        }

        public int Auto_Scale
        {
            set
            {
                if ((report as MatchScout).auto_scale != value)
                {
                    (report as MatchScout).auto_scale = value;
                    OnPropertyChanged("Auto_Scale");
                }
            }
            get
            {
                return (report as MatchScout).auto_scale;
            }
        }

        public int Auto_Exchange
        {
            set
            {
                if ((report as MatchScout).auto_exchange != value)
                {
                    (report as MatchScout).auto_exchange = value;
                    OnPropertyChanged("Auto_Exchange");
                }
            }
            get
            {
                return (report as MatchScout).auto_exchange;
            }
        }

        public int Tele_Switch
        {
            set
            {
                if ((report as MatchScout).tele_switch != value)
                {
                    (report as MatchScout).tele_switch = value;
                    OnPropertyChanged("Tele_Switch");
                }
            }
            get
            {
                return (report as MatchScout).tele_switch;
            }
        }

        public int Tele_Scale
        {
            set
            {
                if ((report as MatchScout).tele_scale != value)
                {
                    (report as MatchScout).tele_scale = value;
                    OnPropertyChanged("Tele_Scale");
                }
            }
            get
            {
                return (report as MatchScout).tele_scale;
            }
        }

        public int Tele_Exchange
        {
            set
            {
                if ((report as MatchScout).tele_exchange != value)
                {
                    (report as MatchScout).tele_exchange = value;
                    OnPropertyChanged("Tele_Exchange");
                }
            }
            get
            {
                return (report as MatchScout).tele_exchange;
            }
        }

        public int Opp_Switch
        {
            set
            {
                if ((report as MatchScout).opp_switch != value)
                {
                    (report as MatchScout).opp_switch = value;
                    OnPropertyChanged("Opp_Switch");
                }
            }
            get
            {
                return (report as MatchScout).opp_switch;
            }
        }

        public int Pckp_Center
        {
            set
            {
                if ((report as MatchScout).pckp_center != value)
                {
                    (report as MatchScout).pckp_center = value;
                    OnPropertyChanged("Pckp_Center");
                }
            }
            get
            {
                return (report as MatchScout).pckp_center;
            }
        }

        public int Pckp_Pyramid
        {
            set
            {
                if ((report as MatchScout).pckp_pyramid != value)
                {
                    (report as MatchScout).pckp_pyramid = value;
                    OnPropertyChanged("Pckp_Pyramid");
                }
            }
            get
            {
                return (report as MatchScout).pckp_pyramid;
            }
        }

        public int Pckp_Exchange
        {
            set
            {
                if ((report as MatchScout).pckp_exchange != value)
                {
                    (report as MatchScout).pckp_exchange = value;
                    OnPropertyChanged("Pckp_Exchange");
                }
            }
            get
            {
                return (report as MatchScout).pckp_exchange;
            }
        }

        public int Pckp_Total
        {
            set
            {
                if ((report as MatchScout).pckp_total != value)
                {
                    (report as MatchScout).pckp_total = value;
                    OnPropertyChanged("Pckp_Total");
                }
            }
            get
            {
                return (report as MatchScout).pckp_total;
            }
        }

        public int Place_Total
        {
            set
            {
                if ((report as MatchScout).place_total != value)
                {
                    (report as MatchScout).place_total = value;
                    OnPropertyChanged("Place_Total");
                }
            }
            get
            {
                return (report as MatchScout).place_total;
            }
        }

        public int Climb_Speed
        {
            set
            {
                if((report as MatchScout).climb_speed != value)
                {
                    (report as MatchScout).climb_speed = value;
                    OnPropertyChanged("Climb_Speed");
                }
            }
            get
            {
                return (report as MatchScout).climb_speed;
            }
        }

        public int Dfnse_Scaled
        {
            set
            {
                if ((report as MatchScout).dfnse_scaled != value)
                {
                    (report as MatchScout).dfnse_scaled = value;
                    OnPropertyChanged("Dfnse_Scaled");
                }
            }
            get
            {
                return (report as MatchScout).dfnse_scaled;
            }
        }

        public bool AutoNone
        {
            set
            {
                if ((report as MatchScout).auto_none != value)
                {
                    (report as MatchScout).auto_none = value;
                    OnPropertyChanged("AutoNone");
                }
            }
            get
            {
                return (report as MatchScout).auto_none;
            }
        }

        public bool AutoBreak
        {
            set
            {
                if ((report as MatchScout).auto_break != value)
                {
                    (report as MatchScout).auto_break = value;
                    OnPropertyChanged("AutoBreak");
                }
            }
            get
            {
                return (report as MatchScout).auto_break;
            }
        }

        public bool Baseline
        {
            set
            {
                if ((report as MatchScout).baseline != value)
                {
                    (report as MatchScout).baseline = value;
                    OnPropertyChanged("Baseline");
                }
            }
            get
            {
                return (report as MatchScout).baseline;
            }
        }

        public bool Auto_Pckp
        {
            set
            {
                if((report as MatchScout).auto_pckp != value)
                {
                    (report as MatchScout).auto_pckp = value;
                    OnPropertyChanged("Auto_Pckp");
                }
            }
            get
            {
                return (report as MatchScout).auto_pckp;
            }
        }

        public bool Auto_Handles_Rand
        {
            set
            {
                if((report as MatchScout).auto_handles_rand != value)
                {
                    (report as MatchScout).auto_handles_rand = value;
                    OnPropertyChanged("Auto_Handles_Rand");
                }
            }
            get
            {
                return (report as MatchScout).auto_handles_rand;
            }
        }

        public bool TeleNone
        {
            set
            {
                if ((report as MatchScout).tele_none != value)
                {
                    (report as MatchScout).tele_none = value;
                    OnPropertyChanged("TeleNone");
                }
            }
            get
            {
                return (report as MatchScout).tele_none;
            }
        }

        public bool Tele
        {
            set
            {
                if (tele != value)
                {
                    tele = value;
                    OnPropertyChanged("Tele");
                }
            }
            get
            {
                return tele;
            }
        }

        public bool TeleBreak
        {
            set
            {
                if ((report as MatchScout).tele_break != value)
                {
                    (report as MatchScout).tele_break = value;
                    OnPropertyChanged("TeleBreak");
                }
            }
            get
            {
                return (report as MatchScout).tele_break;
            }
        }

        public bool Climb_Att
        {
            set
            {
                if ((report as MatchScout).climb_att != value)
                {
                    (report as MatchScout).climb_att = value;
                    OnPropertyChanged("Climb_Att");
                }
            }
            get
            {
                return (report as MatchScout).climb_att;
            }
        }

        public bool Climb_Succ
        {
            set
            {
                if ((report as MatchScout).climb_succ != value)
                {
                    (report as MatchScout).climb_succ = value;
                    OnPropertyChanged("Cilmb_Succ");
                }
            }
            get
            {
                return (report as MatchScout).climb_succ;
            }
        }

        public bool Win
        {
            set
            {
                if ((report as MatchScout).win != value)
                {
                    (report as MatchScout).win = value;
                    OnPropertyChanged("Win");
                }
            }
            get
            {
                return (report as MatchScout).win;
            }
        }

        public bool Auto_Quest
        {
            set
            {
                if ((report as MatchScout).auto_quest != value)
                {
                    (report as MatchScout).auto_quest = value;
                    OnPropertyChanged("Auto_Quest");
                }
            }
            get
            {
                return (report as MatchScout).auto_quest;
            }
        }

        public bool Face_Boss
        {
            set
            {
                if((report as MatchScout).face_boss != value)
                {
                    (report as MatchScout).face_boss = value;
                    OnPropertyChanged("Face_Boss");
                }
            }
        }

        public string TMKey
        {
            set
            {
                if ((report as MatchScout).t_m_key != value)
                {
                    (report as MatchScout).t_m_key = value;
                    OnPropertyChanged("TMKey");
                }
            }
            get
            {
                return (report as MatchScout).t_m_key;
            }
        }

        public string CompKey
        {
            set
            {
                if ((report as MatchScout).comp_key != CompParse(value))
                {
                    (report as MatchScout).comp_key = CompParse(value);
                    OnPropertyChanged("CompKey");
                }
            }
            get
            {
                return (report as MatchScout).comp_key;
            }
        }

        public Button ButtonOne
        {
            get
            {
                if (gears_selected)
                {
                    return load_gear;
                }
                else
                    return drop_gear;
            }
        }

        public Button ButtonTwo
        {
            get
            {
                if (gears_selected)
                {
                    return cent_gear;
                }
                else
                    return load_pckp;
            }
        }

        public Button ButtonThree
        {
            get
            {
                if (gears_selected)
                {
                    return boil_gear;
                }
                else
                    return grnd_pckp;
            }
        }

        public override int ParsePosition(string pos)
        {
            if (pos == null)
            {
                return -1;
            }
            if (pos.Equals("Red 1"))
            {
                return 0;
            }
            if (pos.Equals("Red 2"))
            {
                return 1;
            }
            if (pos.Equals("Red 3"))
            {
                return 2;
            }
            if (pos.Equals("Blue 1"))
            {
                return 3;
            }
            if (pos.Equals("Blue 2"))
            {
                return 4;
            }
            if (pos.Equals("Blue 3"))
            {
                return 5;
            }
            else
                return -1;
        }

        public override string ParsePosition(int pos)
        {
            if (pos == 0)
            {
                return "Red 1";
            }
            if(pos == 1)
            {
                return "Red 2";
            }
            if(pos == 2)
            {
                return "Red 3";
            }
            if(pos == 3)
            {
                return "Blue 1";
            }
            if(pos == 4)
            {
                return "Blue 2";
            }
            if (pos == 5)
            {
                return "Blue 3";
            }
            else
                return null;
        }

        public void setButtonProperties()
        {
            if (tele)
            {
                load_gear = new Button
                {
                    Text = String.Format("Loading Gears = {0}", TeleGearLoad),
                    Command = IncrementCommand,
                    CommandParameter = "load_gear"
                };
                cent_gear = new Button
                {
                    Text = String.Format("Center Gears = {0}", TeleGearCent),
                    Command = IncrementCommand,
                    CommandParameter = "cent_gear"
                };
                boil_gear = new Button
                {
                    Text = String.Format("Boiler Gears = {0}", TeleGearBoil),
                    Command = IncrementCommand,
                    CommandParameter = "boil_gear"
                };
                drop_gear = new Button
                {
                    Text = String.Format("Gears Dropped = {0}", TeleGearDrop),
                    Command = IncrementCommand,
                    CommandParameter = "drop_gear"
                };
                load_pckp = new Button
                {
                    Text = String.Format("Loading Pickup = {0}", TeleLoadPckp),
                    Command = IncrementCommand,
                    CommandParameter = "load_pckp"
                };
                grnd_pckp = new Button
                {
                    Text = String.Format("Ground Pickup = {0}", TeleGrndPckp),
                    Command = IncrementCommand,
                    CommandParameter = "grnd_pckp"
                };
                RefreshButtons();
            }
            else
            {
                load_gear = new Button
                {
                    Text = String.Format("Loading Gears = {0}", AutoGearLoad),
                    Command = IncrementCommand,
                    CommandParameter = "load_gear"
                };
                cent_gear = new Button
                {
                    Text = String.Format("Center Gears = {0}", AutoGearCent),
                    Command = IncrementCommand,
                    CommandParameter = "cent_gear"
                };
                boil_gear = new Button
                {
                    Text = String.Format("Boiler Gears = {0}", AutoGearBoil),
                    Command = IncrementCommand,
                    CommandParameter = "boil_gear"
                };
                drop_gear = new Button
                {
                    Text = String.Format("Gears Dropped = {0}", AutoGearDrop),
                    Command = IncrementCommand,
                    CommandParameter = "drop_gear"
                };
                load_pckp = new Button
                {
                    Text = String.Format("Loading Pickup = {0}", AutoLoadPckp),
                    Command = IncrementCommand,
                    CommandParameter = "load_pckp"
                };
                grnd_pckp = new Button
                {
                    Text = String.Format("Ground Pickup = {0}", AutoGrndPckp),
                    Command = IncrementCommand,
                    CommandParameter = "grnd_pckp"
                };
                RefreshButtons();
            }
        }

        public void Increment(string parameter)
        {
            if (tele)
            {
                switch (parameter)
                {
                    case "load_gear":
                        (report as MatchScout).tele_gear_load++;
                        OnPropertyChanged("TeleGearLoad");
                        setButtonProperties();
                        break;
                    case "cent_gear":
                        (report as MatchScout).tele_gear_cent++;
                        OnPropertyChanged("TeleGearCent");
                        setButtonProperties();
                        break;
                    case "boil_gear":
                        (report as MatchScout).tele_gear_boil++;
                        OnPropertyChanged("TeleGearBoil");
                        setButtonProperties();
                        break;
                    case "drop_gear":
                        (report as MatchScout).tele_gear_drop++;
                        OnPropertyChanged("TeleGearDrop");
                        setButtonProperties();
                        break;
                    case "grnd_pckp":
                        (report as MatchScout).tele_grnd_pckp++;
                        OnPropertyChanged("TeleGrndPckp");
                        setButtonProperties();
                        break;
                    case "load_pckp":
                        (report as MatchScout).tele_load_pckp++;
                        OnPropertyChanged("TeleLoadPckp");
                        setButtonProperties();
                        break;
                }
            }
            else
            {
                switch (parameter)
                {
                    case "load_gear":
                        (report as MatchScout).auto_gear_load++;
                        OnPropertyChanged("AutoGearLoad");
                        setButtonProperties();
                        break;
                    case "cent_gear":
                        (report as MatchScout).auto_gear_cent++;
                        OnPropertyChanged("AutoGearCent");
                        setButtonProperties();
                        break;
                    case "boil_gear":
                        (report as MatchScout).auto_gear_boil++;
                        OnPropertyChanged("AutoGearBoil");
                        setButtonProperties();
                        break;
                    case "drop_gear":
                        (report as MatchScout).auto_gear_drop++;
                        OnPropertyChanged("AutoGearDrop");
                        setButtonProperties();
                        break;
                    case "grnd_pckp":
                        (report as MatchScout).auto_grnd_pckp++;
                        OnPropertyChanged("AutoGrndPckp");
                        setButtonProperties();
                        break;
                    case "load_pckp":
                        (report as MatchScout).auto_load_pckp++;
                        OnPropertyChanged("AutoLoadPckp");
                        setButtonProperties();
                        break;
                }
            }
            //System.Diagnostics.Debug.WriteLine("Command Executed");
        }

        public void RefreshButtons()
        {
            OnPropertyChanged("ButtonOne");
            OnPropertyChanged("ButtonTwo");
            OnPropertyChanged("ButtonThree");
        }

        public string CompParse(string comp_name)
        {
            if (comp_name == "Palm Beach")
            {
                return "2018flwp";
            }
            if (comp_name == "Palmetto")
            {
                return "2018scmp";
            }
            if (comp_name == "Pittsburgh")
            {
                return "2018paca";
            }
            else
                return "unknown";
        }
    }
}
