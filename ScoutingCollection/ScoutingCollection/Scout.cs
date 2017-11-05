﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    public abstract class Scout
    {
        public int team;
        public bool is_match, baseline;
        public String team_key, comments;

        public int getTeam()
        {
            return team;
        }

        public bool getType()
        {
            return is_match;
        }
    }
}
