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
    }
}
