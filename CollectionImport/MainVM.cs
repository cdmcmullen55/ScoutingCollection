using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CollectionImport
{
    public class MainVM
    {
        private String filepath;
        private XmlSerializer serializer;
        private List<Scout> reports;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {

        }

        public String Filepath
        {
            set
            {
                if (filepath != value)
                {
                    filepath = value;
                    OnPropertyChanged("Filepath");
                }
            }
            get
            {
                return filepath;
            }
        }

        public void ImportFile()
        {
            serializer = new XmlSerializer(typeof(List<Scout>));
            System.Xml.XmlReader reader = new System.Xml.XmlReader(filepath);
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