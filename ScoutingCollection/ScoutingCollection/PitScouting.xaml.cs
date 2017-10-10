using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoutingCollection
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PitScouting : TabbedPage
    {
        public MainViewModel mvm;
        public PitScoutingViewModel psvm;

        public static String team_number;

        public PitScouting()
        {
            InitializeComponent();
        }
        public PitScouting(MainViewModel mvm, PitScoutingViewModel psvm)
        {
            this.mvm = mvm;
            this.psvm = psvm;
            this.BindingContext = psvm;
        }
    }
}