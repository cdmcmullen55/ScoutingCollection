using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    abstract class ScoutingReport
    {
        int team;
        string report_type;

        public ScoutingReport(int team_number)
        {
            team = team_number;
        }
    }
}
