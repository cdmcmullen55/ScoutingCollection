using PCLStorage;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace ScoutingCollection
{
    public class MainViewModel
    {
        public List<ScoutVM> reports = new List<ScoutVM>();
        public List<Scout> reportmodels = new List<Scout>();
        int team, match;
        bool currentIsMatch;
        public ScoutVM currentReport;
        private IFile modelfile, vmfile;

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

        public MainViewModel(List<ScoutVM> reports)
        {
            this.reports = reports;
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

        public List<ScoutVM> Reports
        {
            get
            {
                return reports;
            }
        }

        public void InitPitScout()
        {
            currentIsMatch = false;
            currentReport = new PitScoutingViewModel(team);
        }

        public void InitMatchScout()
        {
            currentIsMatch = true;
            currentReport = new MatchVM(team, match);
        }

        public void SaveForExport()
        {
            SaveForExport(false);
        }

        public async void SaveForExport(bool savevm)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("ReportSave",
                CreationCollisionOption.OpenIfExists);
            if (savevm)
            {
                vmfile = await folder.CreateFileAsync("vmmodels.xml", 
                    CreationCollisionOption.ReplaceExisting);
                await vmfile.WriteAllTextAsync(SerializeReportsList(true));
            }
            else
            {
                modelfile = await folder.CreateFileAsync("reportmodels.xml",
                    CreationCollisionOption.ReplaceExisting);
                GenerateReportsList();
                await modelfile.WriteAllTextAsync(SerializeReportsList());
            }
        }

        public void Export()
        {
            SaveForExport();
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmailAttachments && emailMessenger.CanSendEmailAttachments)
            {
                var email = new EmailMessageBuilder()
                    .To("bd541331@ahschool.com")
                    .Subject("Xamarin Messaging Plugin")
                    .Body("Well hello there from Xam.Messaging.Plugin")
                    .WithAttachment(modelfile.Path, "xml")
                    .Build();
                emailMessenger.SendEmail(email);
            }
        }

        private void GenerateReportsList()
        {
            foreach(ScoutVM report in reports)
            {
                reportmodels.Add(report.report);
            }
        }

        private string SerializeReportsList()
        {
            return SerializeReportsList(false);
        }

        private string SerializeReportsList(bool serializevm)
        {
            string results;
            XmlSerializer serializer;
            StringWriter textWriter = new StringWriter();
            if (serializevm)
            {
                serializer = new XmlSerializer(typeof(List<ScoutVM>));
                serializer.Serialize(textWriter, (reports as List<ScoutVM>));
            }
            else
            {
                serializer = new XmlSerializer(typeof(List<Scout>));
                serializer.Serialize(textWriter, (reportmodels as List<Scout>));
            }
            results = textWriter.ToString();
            return results;
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
