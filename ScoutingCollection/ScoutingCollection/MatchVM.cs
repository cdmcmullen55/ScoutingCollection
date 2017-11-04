using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    public class MatchVM : ScoutVM
    {
        MatchVM(int team_num, int match_num)
        {
            report = new MatchScout(team_num, match_num);
        }

        public int MatchNumber
        {
            set
            {
                if ((report as MatchScout).match_number != value)
                {
                    (report as MatchScout).match_number = value;
                    OnPropertyChanged("MatchNumber");
                }
            }
            get
            {
                return (report as MatchScout).match_number;
            }
        }

        public int AutoGear
        {
            set
            {
                if ((report as MatchScout).auto_gear != value)
                {
                    (report as MatchScout).auto_gear = value;
                    OnPropertyChanged("AutoGear");
                }
            }
            get
            {
                return (report as MatchScout).auto_gear;
            }
        }

        public int AutoGrndGear
        {
            set
            {
                if ((report as MatchScout).auto_grnd_gear != value)
                {
                    (report as MatchScout).auto_grnd_gear = value;
                    OnPropertyChanged("AutoGrndGear");
                }
            }
            get
            {
                return (report as MatchScout).auto_grnd_gear;
            }
        }

        public int AutoLoadGear
        {
            set
            {
                if ((report as MatchScout).auto_load_gear != value)
                {
                    (report as MatchScout).auto_load_gear = value;
                    OnPropertyChanged("AutoLoadGear");
                }
            }
            get
            {
                return (report as MatchScout).auto_load_gear;
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

        public int TeleGear
        {
            set
            {
                if ((report as MatchScout).tele_gear != value)
                {
                    (report as MatchScout).tele_gear = value;
                    OnPropertyChanged("TeleGear");
                }
            }
            get
            {
                return (report as MatchScout).tele_gear;
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
                if ((report as MatchScout).comp_key != value)
                {
                    (report as MatchScout).comp_key = value;
                    OnPropertyChanged("CompKey");
                }
            }
            get
            {
                return (report as MatchScout).comp_key;
            }
        }
    }
}
