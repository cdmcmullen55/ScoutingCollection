using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CollectionImport
{
    [XmlInclude(typeof(PitScout))]
    [XmlInclude(typeof(MatchScout))]
    public abstract class Scout
    {
        public int team, start_pos;
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
