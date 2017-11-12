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

        public int AutoGearLoad
        {
            set
            {
                if ((report as MatchScout).auto_gear_load != value)
                {
                    (report as MatchScout).auto_gear_load = value;
                    OnPropertyChanged("AutoGearLoad");
                }
            }
            get
            {
                return (report as MatchScout).auto_gear_load;
            }
        }

        public int AutoGearCent
        {
            set
            {
                if ((report as MatchScout).auto_gear_cent != value)
                {
                    (report as MatchScout).auto_gear_cent = value;
                    OnPropertyChanged("AutoGearCent");
                }
            }
            get
            {
                return (report as MatchScout).auto_gear_cent;
            }
        }

        public int AutoGearBoil
        {
            set
            {
                if ((report as MatchScout).auto_gear_boil != value)
                {
                    (report as MatchScout).auto_gear_boil = value;
                    OnPropertyChanged("AutoGearBoil");
                }
            }
            get
            {
                return (report as MatchScout).auto_gear_boil;
            }
        }

        public int AutoGrndPckp
        {
            set
            {
                if ((report as MatchScout).auto_grnd_pckp != value)
                {
                    (report as MatchScout).auto_grnd_pckp = value;
                    OnPropertyChanged("AutoGrndPckp");
                }
            }
            get
            {
                return (report as MatchScout).auto_grnd_pckp;
            }
        }

        public int AutoLoadPckp
        {
            set
            {
                if ((report as MatchScout).auto_load_pckp != value)
                {
                    (report as MatchScout).auto_load_pckp = value;
                    OnPropertyChanged("AutoLoadPckp");
                }
            }
            get
            {
                return (report as MatchScout).auto_load_pckp;
            }
        }

        public int AutoGearAtt
        {
            set
            {
                if ((report as MatchScout).auto_gear_att != value)
                {
                    (report as MatchScout).auto_gear_att = value;
                    OnPropertyChanged("AutoGearAtt");
                }
            }
            get
            {
                return (report as MatchScout).auto_gear_att;
            }
        }

        public int AutoGearDrop
        {
            set
            {
                if ((report as MatchScout).auto_gear_drop != value)
                {
                    (report as MatchScout).auto_gear_drop = value;
                    OnPropertyChanged("AutoGearDrop");
                }
            }
            get
            {
                return (report as MatchScout).auto_gear_drop;
            }
        }

        public int TeleGearDrop
        {
            set
            {
                if ((report as MatchScout).tele_gear_drop != value)
                {
                    (report as MatchScout).tele_gear_drop = value;
                    OnPropertyChanged("TeleGearDrop");
                }
            }
            get
            {
                return (report as MatchScout).tele_gear_drop;
            }
        }

        public int TeleGearLoad
        {
            set
            {
                if ((report as MatchScout).tele_gear_load != value)
                {
                    (report as MatchScout).tele_gear_load = value;
                    OnPropertyChanged("TeleGearLoad");
                }
            }
            get
            {
                return (report as MatchScout).tele_gear_load;
            }
        }

        public int TeleGearCent
        {
            set
            {
                if ((report as MatchScout).tele_gear_cent != value)
                {
                    (report as MatchScout).tele_gear_cent = value;
                    OnPropertyChanged("TeleGearCent");
                }
            }
            get
            {
                return (report as MatchScout).tele_gear_cent;
            }
        }

        public int TeleGearBoil
        {
            set
            {
                if ((report as MatchScout).tele_gear_boil != value)
                {
                    (report as MatchScout).tele_gear_boil = value;
                    OnPropertyChanged("TeleGearBoil");
                }
            }
            get
            {
                return (report as MatchScout).tele_gear_boil;
            }
        }

        public int TeleGearAtt
        {
            set
            {
                if ((report as MatchScout).tele_gear_att != value)
                {
                    (report as MatchScout).tele_gear_att = value;
                    OnPropertyChanged("TeleGearAtt");
                }
            }
            get
            {
                return (report as MatchScout).tele_gear_att;
            }
        }

        public int TeleGrndPckp
        {
            set
            {
                if ((report as MatchScout).tele_grnd_pckp != value)
                {
                    (report as MatchScout).tele_grnd_pckp = value;
                    OnPropertyChanged("TeleGrndPckp");
                }
            }
            get
            {
                return (report as MatchScout).tele_grnd_pckp;
            }
        }

        public int TeleLoadPckp
        {
            set
            {
                if ((report as MatchScout).tele_load_pckp != value)
                {
                    (report as MatchScout).tele_load_pckp = value;
                    OnPropertyChanged("TeleLoadPckp");
                }
            }
            get
            {
                return (report as MatchScout).tele_load_pckp;
            }
        }

        public int TkoffSpeed
        {
            set
            {
                if ((report as MatchScout).tkoff_speed != value)
                {
                    (report as MatchScout).tkoff_speed = value;
                    OnPropertyChanged("TkoffSpeed");
                }
            }
            get
            {
                return (report as MatchScout).tkoff_speed;
            }
        }

        public int DfnseRate
        {
            set
            {
                if ((report as MatchScout).dfnse_rate != value)
                {
                    (report as MatchScout).dfnse_rate = value;
                    OnPropertyChanged("DfnseRate");
                }
            }
            get
            {
                return (report as MatchScout).dfnse_rate;
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

        public bool TkoffAtt
        {
            set
            {
                if ((report as MatchScout).tkoff_att != value)
                {
                    (report as MatchScout).tkoff_att = value;
                    OnPropertyChanged("TkoffAtt");
                }
            }
            get
            {
                return (report as MatchScout).tkoff_att;
            }
        }

        public bool TkoffSucc
        {
            set
            {
                if ((report as MatchScout).tkoff_succ != value)
                {
                    (report as MatchScout).tkoff_succ = value;
                    OnPropertyChanged("TkoffSucc");
                }
            }
            get
            {
                return (report as MatchScout).tkoff_succ;
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

        public bool Rotors
        {
            set
            {
                if ((report as MatchScout).rotors != value)
                {
                    (report as MatchScout).rotors = value;
                    OnPropertyChanged("Rotors");
                }
            }
            get
            {
                return (report as MatchScout).rotors;
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
            if (comp_name == "Orlando")
            {
                return "2018flor";
            }
            else
                return "unknown";
        }
    }
}
