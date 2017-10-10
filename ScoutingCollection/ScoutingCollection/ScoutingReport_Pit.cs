using PCLStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScoutingCollection
{
    class ScoutingReport_Pit : ScoutingReport
    {
        int team;
        string report_type;
        string file_name;

        public ScoutingReport_Pit(int team_number, PitScoutingViewModel report) :
            base(team_number)
        {
            team = team_number;
            report_type = "Pit";
            SerializeReport(report);
        }

        public int getTeam()
        {
            return team;
        }

        public string getType()
        {
            return report_type;
        }

        public async void SerializeReport(PitScoutingViewModel report)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("Reports",
                CreationCollisionOption.OpenIfExists);
            file_name = team + "_pit_2017" + ".xml";
            IFile file = await folder.CreateFileAsync(file_name,
                CreationCollisionOption.ReplaceExisting);
            var serializer = new XmlSerializer(typeof(PitScoutingViewModel));
            TextWriter writer = new StreamWriter(file_name);
        }
    }
}
