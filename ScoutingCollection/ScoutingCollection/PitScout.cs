using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    public class PitScout : Scout
    {
        public int climb_time, num_cubes, does_scale, baseline, cims_used, speed_fps, speed_scaled, robot_wt, ball_cap, run_sec, run_scale, strategy,
             acc_scale;  
        public bool fuel, vision, auto_low, tele_low, climb;

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
