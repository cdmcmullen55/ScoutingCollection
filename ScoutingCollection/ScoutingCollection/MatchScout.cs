using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
	class MatchScout
	{
		public int team, match_number, auto_gear_cent, auto_gear_load, auto_gear_boil, auto_grnd_gear, auto_load_gear,
			auto_g_c_att, auto_g_l_att, auto_g_b_att, auto_gear_drop, tele_gear_drop, tele_gear_cent, tele_gear_load,
			tele_gear_boil, tele_grnd_pckp, tele_load_pckp, tkoff_speed, dfnse_rate;
		public bool baseline, auto_none, auto_break, tele_none, tele_break, tkoff_att, tkoff_succ, win, rotors, pascals;
		public String t_m_key, comp_key, team_key, comments;
        public bool isMatch = true;
	}
}
//https://stackoverflow.com/questions/4366728/mvvm-and-nested-view-models