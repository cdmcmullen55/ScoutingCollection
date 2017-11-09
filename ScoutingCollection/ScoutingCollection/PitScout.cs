using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    public class PitScout : Scout
    {
        public int cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, ground_gear_scale, run_sec, run_scale, strategy, auto_ball, tele_gears,
            tele_balls, acc_scale, climb_time;
        public bool fuel, gears, shift_gears, vision, active_gear, ground_gear, ground_ball, auto_gear, auto_low, tele_low,
            climb;
        public String robot_key, drive_train, start_pos, file_name;

        public PitScout()
        {
            is_match = false;
        }

        public PitScout(int team_num)
        {
            team = team_num;
            is_match = false;
        }
    }
}
