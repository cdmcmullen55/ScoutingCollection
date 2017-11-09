using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScoutingCollection
{
    public class MainViewModel
    {
        public ObservableCollection<ScoutVM> reports = new ObservableCollection<ScoutVM>();
        int team, match;
        bool currentIsMatch;
        public ScoutVM currentReport;

        public event PropertyChangedEventHandler PropertyChanged;

        //public System.Windows.Input.ICommand PitScoutCommand { private set; get; }
        //public System.Windows.Input.ICommand MatchScoutCommand { private set; get; }

        public MainViewModel()
        {
            /* PitScoutCommand = new Command(
           execute: () =>
           {
               currentReport = new PitScoutingViewModel(team);
               RefreshCanExecutes();
           },
           canExecute: () =>
           {
               return(team != 0);
           });

            MatchScoutCommand = new Command(
            execute: () =>
            {
                currentReport = new MatchVM(team, match);
                RefreshCanExecutes();
            },
            canExecute: () =>
            {
                return (match != 0 && team != 0);
            }); */
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

        public ScoutVM CurrentReport
        {
            set
            {
                if(currentReport != value)
                {
                    currentReport = value;
                    OnPropertyChanged("CurrentReport");
                }
            }
            get
            {
                return currentReport;
            }
        }

        public void InitPitScout()
        {
            currentIsMatch = false;
            currentReport = new PitScoutingViewModel(team);
        }

        /* void RefreshCanExecutes()
        {
            ((Command)PitScoutCommand).ChangeCanExecute();
        } */

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
