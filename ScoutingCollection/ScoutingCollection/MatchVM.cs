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
        public bool place_selected, tele;

        public List<String> undolist = new List<string>();

        public Button place_scale, place_switch, place_opp, place_exch, pckp_exch, pckp_pyr, pckp_grnd;

        public ICommand IncrementCommand { private set; get; }

        public MatchVM(int team_num, int match_num, int start_pos)
        {
            report = new MatchScout(team_num, match_num, start_pos);
            place_selected = true;
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

        public int Auto_Pyr_Pckp
        {
            set
            {
                if ((report as MatchScout).auto_pyr_pckp != value)
                {
                    (report as MatchScout).auto_pyr_pckp = value;
                    OnPropertyChanged("Auto_Pyr_Pckp");
                }
            }
            get
            {
                return (report as MatchScout).auto_pyr_pckp;
            }
        }

        public int Auto_Grnd_Pckp
        {
            set
            {
                if((report as MatchScout).auto_grnd_pckp != value)
                {
                    (report as MatchScout).auto_grnd_pckp = value;
                    OnPropertyChanged("Auto_Grnd_Pckp");
                }
            }
            get
            {
                return (report as MatchScout).auto_grnd_pckp;
            }
        }

        public int Auto_Exch_Pckp
        {
            set
            {
                if((report as MatchScout).auto_exch_pckp != value)
                {
                    (report as MatchScout).auto_exch_pckp = value;
                    OnPropertyChanged("Auto_Exch_Pckp");
                }
            }
            get
            {
                return (report as MatchScout).auto_exch_pckp;
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

        public int Pckp_Ground
        {
            set
            {
                if ((report as MatchScout).pckp_grnd != value)
                {
                    (report as MatchScout).pckp_grnd = value;
                    OnPropertyChanged("Pckp_Ground");
                }
            }
            get
            {
                return (report as MatchScout).pckp_grnd;
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
                if (place_selected)
                {
                    return place_switch;
                }
                else
                    return pckp_pyr;
            }
        }

        public Button ButtonTwo
        {
            get
            {
                if (place_selected)
                {
                    return place_scale;
                }
                else
                    return pckp_grnd;
            }
        }

        public Button ButtonThree
        {
            get
            {
                if (place_selected)
                {
                    return place_opp;
                }
                else
                    return pckp_exch;
            }
        }

        public Button ButtonFour
        {
            get
            {
                return place_exch;
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
                place_switch = new Button
                {
                    Text = String.Format("Switch Cubes = {0}", Tele_Switch),
                    Command = IncrementCommand,
                    CommandParameter = "place_switch"
                };
                place_scale = new Button
                {
                    Text = String.Format("Scale Cubes = {0}", Tele_Scale),
                    Command = IncrementCommand,
                    CommandParameter = "place_scale"
                };
                place_opp = new Button
                {
                    Text = String.Format("Opposing Cubes = {0}", Opp_Switch),
                    Command = IncrementCommand,
                    CommandParameter = "place_opp"
                };
                place_exch = new Button
                {
                    Text = String.Format("Exchange Cubes = {0}", Tele_Exchange),
                    Command = IncrementCommand,
                    CommandParameter = "place_exch"
                };
                pckp_pyr = new Button
                {
                    Text = String.Format("Pyramid Pickup = {0}", Pckp_Pyramid),
                    Command = IncrementCommand,
                    CommandParameter = "pckp_pyr"
                };
                pckp_grnd = new Button
                {
                    Text = String.Format("Ground Pickup = {0}", Pckp_Ground),
                    Command = IncrementCommand,
                    CommandParameter = "pckp_grnd"
                };
                pckp_exch = new Button
                {
                    Text = String.Format("Exchange Pickup = {0}", Pckp_Exchange),
                    Command = IncrementCommand,
                    CommandParameter = "pckp_exch"
                };
                RefreshButtons();
            }
            else
            {
                place_switch = new Button
                {
                    Text = String.Format("Switch Cubes = {0}", Auto_Switch),
                    Command = IncrementCommand,
                    CommandParameter = "place_switch"
                };
                place_scale = new Button
                {
                    Text = String.Format("Scale Cubes = {0}", Auto_Scale),
                    Command = IncrementCommand,
                    CommandParameter = "place_scale"
                };
                place_opp = new Button
                {
                    Text = "Opposing Switch Disabled",
                    Command = IncrementCommand,
                    CommandParameter = null,
                    IsEnabled = false
                };
                place_exch = new Button
                {
                    Text = String.Format("Exchange Cubes = {0}", Auto_Exchange),
                    Command = IncrementCommand,
                    CommandParameter = "place_exch"
                };
                pckp_pyr = new Button
                {
                    Text = String.Format("Pyramid Pickup = {0}", Auto_Pyr_Pckp),
                    Command = IncrementCommand,
                    CommandParameter = "pckp_pyr"
                };
                pckp_grnd = new Button
                {
                    Text = String.Format("Ground Pickup = {0}", Auto_Grnd_Pckp),
                    Command = IncrementCommand,
                    CommandParameter = "pckp_grnd"
                };
                pckp_exch = new Button
                {
                    Text = String.Format("Exchange Pickup = {0}", Auto_Exch_Pckp),
                    Command = IncrementCommand,
                    CommandParameter = "pckp_exch"
                };
                RefreshButtons();
            }
        }

        public void Increment(string parameter)
        {
            undolist.Add(parameter);
            if (tele)
            {
                switch (parameter)
                {
                    case "place_switch":
                        (report as MatchScout).tele_switch++;
                        OnPropertyChanged("Tele_Switch");
                        setButtonProperties();
                        break;
                    case "place_scale":
                        (report as MatchScout).tele_scale++;
                        OnPropertyChanged("Tele_Scale");
                        setButtonProperties();
                        break;
                    case "place_opp":
                        (report as MatchScout).opp_switch++;
                        OnPropertyChanged("Opp_Switch");
                        setButtonProperties();
                        break;
                    case "place_exch":
                        (report as MatchScout).tele_exchange++;
                        OnPropertyChanged("Tele_Exchange");
                        setButtonProperties();
                        break;
                    case "pckp_pyr":
                        (report as MatchScout).pckp_pyramid++;
                        OnPropertyChanged("Pckp_Pyramid");
                        setButtonProperties();
                        break;
                    case "pckp_grnd":
                        (report as MatchScout).pckp_grnd++;
                        OnPropertyChanged("Pckp_Ground");
                        setButtonProperties();
                        break;
                    case "pckp_exch":
                        (report as MatchScout).pckp_exchange++;
                        OnPropertyChanged("Pckp_Exchange");
                        setButtonProperties();
                        break;
                }
            }
            else
            {
                switch (parameter)
                {
                    case "place_switch":
                        (report as MatchScout).auto_switch++;
                        OnPropertyChanged("Auto_Switch");
                        setButtonProperties();
                        break;
                    case "place_scale":
                        (report as MatchScout).auto_scale++;
                        OnPropertyChanged("Auto_Scale");
                        setButtonProperties();
                        break;
                    case "place_exch":
                        (report as MatchScout).auto_exchange++;
                        OnPropertyChanged("Auto_Exchange");
                        setButtonProperties();
                        break;
                    case "pckp_pyr":
                        (report as MatchScout).auto_pyr_pckp++;
                        OnPropertyChanged("Auto_Pyr_Pckp");
                        setButtonProperties();
                        break;
                    case "pckp_grnd":
                        (report as MatchScout).auto_grnd_pckp++;
                        OnPropertyChanged("Auto_Grnd_Pckp");
                        setButtonProperties();
                        break;
                    case "pckp_exch":
                        (report as MatchScout).auto_exch_pckp++;
                        OnPropertyChanged("Auto_Exch_Pckp");
                        setButtonProperties();
                        break;
                }
            }
            //System.Diagnostics.Debug.WriteLine("Command Executed");
        }

        public void Undo()
        {
            string parameter = undolist[0];
            undolist.RemoveAt(0);
            if (tele)
            {
                switch (parameter)
                {
                    case "place_switch":
                        (report as MatchScout).tele_switch--;
                        OnPropertyChanged("Tele_Switch");
                        setButtonProperties();
                        break;
                    case "place_scale":
                        (report as MatchScout).tele_scale--;
                        OnPropertyChanged("Tele_Scale");
                        setButtonProperties();
                        break;
                    case "place_opp":
                        (report as MatchScout).opp_switch--;
                        OnPropertyChanged("Opp_Switch");
                        setButtonProperties();
                        break;
                    case "place_exch":
                        (report as MatchScout).tele_exchange--;
                        OnPropertyChanged("Tele_Exchange");
                        setButtonProperties();
                        break;
                    case "pckp_pyr":
                        (report as MatchScout).pckp_pyramid--;
                        OnPropertyChanged("Pckp_Pyramid");
                        setButtonProperties();
                        break;
                    case "pckp_grnd":
                        (report as MatchScout).pckp_grnd--;
                        OnPropertyChanged("Pckp_Ground");
                        setButtonProperties();
                        break;
                    case "pckp_exch":
                        (report as MatchScout).pckp_exchange--;
                        OnPropertyChanged("Pckp_Exchange");
                        setButtonProperties();
                        break;
                }
            }
            else
            {
                switch (parameter)
                {
                    case "place_switch":
                        (report as MatchScout).auto_switch--;
                        OnPropertyChanged("Auto_Switch");
                        setButtonProperties();
                        break;
                    case "place_scale":
                        (report as MatchScout).auto_scale--;
                        OnPropertyChanged("Auto_Scale");
                        setButtonProperties();
                        break;
                    case "place_exch":
                        (report as MatchScout).auto_exchange--;
                        OnPropertyChanged("Auto_Exchange");
                        setButtonProperties();
                        break;
                    case "pckp_pyr":
                        (report as MatchScout).auto_pyr_pckp--;
                        OnPropertyChanged("Auto_Pyr_Pckp");
                        setButtonProperties();
                        break;
                    case "pckp_grnd":
                        (report as MatchScout).auto_grnd_pckp--;
                        OnPropertyChanged("Auto_Grnd_Pckp");
                        setButtonProperties();
                        break;
                    case "pckp_exch":
                        (report as MatchScout).auto_exch_pckp--;
                        OnPropertyChanged("Auto_Exch_Pckp");
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
