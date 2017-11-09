﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScoutingCollection
{
    public abstract class ScoutVM : INotifyPropertyChanged
    {
        public Scout report;
        public bool isMatch;
        public string preview;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Team
        {
            set
            {
                if (report.team != value)
                {
                    report.team = value;
                    OnPropertyChanged("Team");
                    SetTeamKey();
                    if (!report.getType())
                        SetRobotKey();
                }
            }
            get
            {
                return report.team;
            }
        }

        public String Team_Key
        {
            set
            {
                if (report.team_key != value)
                {
                    report.team_key = value;
                    OnPropertyChanged("Team_Key");
                }
            }
            get
            {
                return report.team_key;
            }
        }

        public String Robot_Key
        {
            set
            {
                if ((report as PitScout).robot_key != value)
                {
                    (report as PitScout).robot_key = value;
                    OnPropertyChanged("Robot_Key");
                }
            }
            get
            {
                return (report as PitScout).robot_key;
            }
        }

        public string Preview
        {
            set
            {
                preview = value;
                OnPropertyChanged("Preview");
            }
            get
            {
                return preview;
            }
        }

        public void generatePreview()
        {
            XmlSerializer serializer;
            StringWriter textWriter = new StringWriter();
            if (isMatch)
            {
                serializer = new XmlSerializer(typeof(MatchScout));
                serializer.Serialize(textWriter, (report as MatchScout));
            }
            else
            {
                serializer = new XmlSerializer(typeof(PitScout));
                serializer.Serialize(textWriter, (report as PitScout));
            }
            preview = textWriter.ToString();
        }

        private void SetTeamKey()
        {
            this.Team_Key = "frc" + report.team;
        }

        private void SetRobotKey()
        {
            this.Robot_Key = report.team_key + "_2017";
        }

        public bool getType()
        {
            return report.getType();
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
