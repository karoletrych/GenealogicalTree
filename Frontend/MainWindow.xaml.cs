using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using Application;

namespace Frontend
{
    public partial class TreeViewMultipleTemplatesSample : Window
    {
        public TreeViewMultipleTemplatesSample()
        {
            InitializeComponent();

            XmlSerializer serializer = new XmlSerializer(typeof(family));
            var family = (family)serializer.Deserialize(new XmlTextReader("family.xml"));
            TrvFamilies.ItemsSource = family.people;
        }
    }
}