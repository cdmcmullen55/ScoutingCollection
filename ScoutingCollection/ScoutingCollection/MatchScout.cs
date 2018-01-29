using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
	public class MatchScout : Scout
	{
		public int  match_number, auto_switch, auto_scale, auto_exchange, auto_pyr_pckp, auto_grnd_pckp, auto_exch_pckp, tele_switch, tele_scale, 
            tele_exchange, opp_switch, pckp_grnd, pckp_pyramid, pckp_exchange, climb_speed, dfnse_scaled, pckp_total, place_total;
		public bool auto_none, auto_break, auto_handles_rand, tele_none, tele_break, climb_att, climb_succ, defense, win, auto_quest, 
            face_boss;
		public String t_m_key, comp_key;

        public MatchScout()
        {
            team = 0;
            match_number = 0;
            is_match = true;
        }

        public MatchScout(int team_num, int match_num)
        {
            team = team_num;
            match_number = match_num;
            is_match = true;
        }
	}
}
//https://stackoverflow.com/questions/4366728/mvvm-and-nested-view-models