using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
	public class MatchScout : Scout
	{
		public int  match_number, auto_gear, auto_grnd_gear, auto_load_gear,
			auto_gear_att, auto_gear_drop, tele_gear_drop ,	tele_gear, tele_gear_att, tele_grnd_pckp, tele_load_pckp,
            tkoff_speed, dfnse_rate;
        //gears attempted shouldn't be interacre with -- just scored plus dropped
		public bool auto_none, auto_break, tele_none, tele_break, tkoff_att, tkoff_succ, win, rotors;
		public String t_m_key, comp_key;
        public MatchScout(int team_num, int match_num)
        {
            team = team_num;
            match_number = match_num;
            is_match = true;
        }
	}
}
//https://stackoverflow.com/questions/4366728/mvvm-and-nested-view-models