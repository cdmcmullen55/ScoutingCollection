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
        int team;
        bool currentIsMatch;
        PitScoutingViewModel currentPit;
        MatchScoutingViewModel currentMatch;

        public event PropertyChangedEventHandler PropertyChanged;

        public System.Windows.Input.ICommand PitScoutCommand { private set; get; }

        public MainViewModel()
        {
           PitScoutCommand = new Command(
           execute: () =>
           {
               currentPit = new PitScoutingViewModel(team);
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
