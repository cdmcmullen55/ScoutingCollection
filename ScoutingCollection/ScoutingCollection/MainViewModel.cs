using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingCollection
{
    public class MainViewModel
    {
        List<Scout> reports;
        int team;
        bool currentIsMatch;
        PitScoutingViewModel currentPit;
        MatchScoutingViewModel currentMatch;
    }
}
