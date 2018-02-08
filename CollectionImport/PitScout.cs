using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionImport
{
    public class PitScout : Scout
    {
        public int cims_used, speed_fps, speed_scaled, robot_weight, num_cubes, climb_time;
        
        public bool does_scale, auto_switch, auto_scale, auto_handles_rand, climb, vision;
       
        public String robot_key, drive_train, file_name;

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
