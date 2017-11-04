using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScoutingCollection
{
    public class MainViewModel
    {
        List<Scout> reports;
        int team, match;
        bool currentIsMatch;
        ScoutVM currentReport;

        public event PropertyChangedEventHandler PropertyChanged;

        public System.Windows.Input.ICommand PitScoutCommand { private set; get; }
        public System.Windows.Input.ICommand MatchScoutCommand { private set; get; }

        public MainViewModel()
        {
           PitScoutCommand = new Command(
           execute: () =>
           {
               currentReport = new PitScoutingViewModel(team);
               RefreshCanExecutes();
           },
           canExecute: () =>
           {
               return(team != 0);
           });
        }

        public int Team
        {
            set
            {
                if (team != value)
                {
                    team = value;
                    OnPropertyChanged("Team");
                }
            }
            get
            {
                return team;
            }
        }

        public int Match
        {
            set
            {
                if (match != value)
                {
                    match = value;
                    OnPropertyChanged("Match");
                }
            }
            get
            {
                return match;
            }
        }

        void RefreshCanExecutes()
        {
            ((Command)PitScoutCommand).ChangeCanExecute();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
