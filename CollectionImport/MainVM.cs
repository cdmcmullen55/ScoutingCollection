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

        public async Task ImportFile()
        {
            serializer = new XmlSerializer(typeof(List<Scout>));
            XmlReaderSettings settings = new XmlReaderSettings
            {
                Async = true
            };
            XmlReader reader;
            await Task.Run(() =>
                { reader = XmlReader.Create(filepath, settings); }
            );
            
            reports = (List<Scout>)serializer.Deserialize(reader);
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